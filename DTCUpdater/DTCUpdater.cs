using System;
using System.Windows.Forms;
using DTC.Common;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Xml;
using System.Threading;
using System.Net;
using System.ComponentModel;

using System.Diagnostics;

namespace DTC
{
    static class Updater
    {
        

        private static frmUpdate fUpdater = new frmUpdate();


        public static void CheckIntegrity()
        {
            if(!File.Exists(".\\DTCLauncher.exe"))
            {
                throw new Exception("Erreur d'intégrité, il manque le fichier DTCLauncher.exe");
            }
            if (!File.Exists(".\\DTCCommon.dll"))
            {
                throw new Exception("Erreur d'intégrité, il manque le fichier DTCCommon.dll");
            }
            if (!File.Exists(".\\DTCUpdater.exe"))
            {
                throw new Exception("Erreur d'intégrité, il manque le fichier DTCUpdater.exe");
            }
        }



        public static void CheckRequiredPackages()
        {            
            #region Recherche des paquets obligatoires non installés

            foreach(cPackage ServerPackage in ServerPackages.Packages.GetPackages())
            {
                string sName = ServerPackage.Name;
                string sVersion = ServerPackage.Version;
                
                //verifie si le paquet est present sur le client
                cPackage ClientPackage = ClientPackages.Packages.GetPackage(sName);

                //si aucune correspondance client et force install ?
                if (ClientPackage == null && ServerPackage.ForceInstall)
                {

                    #region "INSTALL FORCE"

                    try
                    {
                        //install
                        Console.WriteLine("FORCE INSTALL: Package " + sName + " @ " + sVersion);


                        //Mise en queue du (archive)DOWNLOAD
                        ArchiveDownload pD = new ArchiveDownload();
                        pD.DownloadFile = Path.GetFullPath(Paths.GetTempPath() + "\\" + ServerPackage.GetParam("archive"));
                        pD.DownloadUrl = ServerPackage.GetParam("download_url");
                        pD.package = sName;
                        Downloader.DownloadQueue.Add(pD);
                    }
                    catch (Exception E)
                    {
                        throw E;
                    }

                    #endregion
                }
                //si marqué "a la main" pour installation
                else if((ClientPackage != null) && (ClientPackage.GetParam("install")=="true"))
                {
                    #region "INSTALL MANU"

                    try
                    {
                        //install
                        Console.WriteLine("MANU INSTALL: Package " + sName + " @ " + sVersion);


                        //Mise en queue du (archive)DOWNLOAD
                        ArchiveDownload pD = new ArchiveDownload();
                        pD.DownloadFile = Path.GetFullPath(Paths.GetTempPath() + "\\" + ServerPackage.GetParam("archive"));
                        pD.DownloadUrl = ServerPackage.GetParam("download_url");
                        pD.package = sName;
                        Downloader.DownloadQueue.Add(pD);
                    }
                    catch (Exception E)
                    {
                        throw E;
                    }

                    #endregion
                }
            }


            //TODO: statut FAIT/RIEN A FAIRE/ERREUR etc

            #endregion  
        }


        public static void CheckPackageUpdates()
        {
            #region Recherche des mises a jours de fichiers sur les paquets deja installés

            foreach (cPackage ServerPackage in ServerPackages.Packages.GetPackages())
            {
                string sName = ServerPackage.Name;
                string sVersion = ServerPackage.Version;

                //verifie si le paquet est present sur le client
                cPackage ClientPackage = ClientPackages.Packages.GetPackage(sName);

                if (ClientPackage != null)
                {
                    //verifie la version du paquet du client
                    string cVersion = ClientPackage.Version;
                    if (Int16.Parse(cVersion) < Int16.Parse(sVersion))
                    {
                        //todo: a deplacer
                        #region "UPDATE"
                        try
                        {
                            //update
                            Console.WriteLine("TO UPDATE: Package " + sName + " From " + cVersion + " To " + sVersion);

                            //pour chaque fichier référencé su le serv, verifie s'il existe en local
                            foreach (XmlNode nodeFile in ServerPackage.GetXml().SelectNodes("//file"))
                            {
                                string sMsg = nodeFile.SelectSingleNode("@path").InnerText;
                                //Console.WriteLine(sMsg);


                                string sFileFullPath = Paths.ComputePath(nodeFile.SelectSingleNode("@path").InnerText, ServerPackage.GetParam("folder"));

                                // -> existe pas ? télécharge !
                                if (!File.Exists(sFileFullPath))
                                {
                                    Console.WriteLine("DOWNLOAD: New File " + nodeFile.SelectSingleNode("@url").InnerText + " to " + sFileFullPath);


                                    FileDownload fD = new FileDownload();

                                    fD.DownloadFile = sFileFullPath;
                                    fD.DownloadUrl = nodeFile.SelectSingleNode("@url").InnerText;
                                    fD.package = sName;

                                    Downloader.DownloadQueue.Add(fD);


                                    //todo DownloadFile(nodeFile.SelectSingleNode("@url").InnerText, sFileFullPath);
                                }
                                else
                                {


                                    string sFileRemoteMD5 = nodeFile.SelectSingleNode("@md5").InnerText;

                                    //todo: sFileLocalMD5 = GetFileMD5(sFileFullPath);
                                    string sFileLocalMD5 = MD5.GetMD5HashFromFile(sFileFullPath);

                                    //->  compare le md5 local avec celui du fichier du serveur                                
                                    if (sFileLocalMD5 != sFileRemoteMD5)
                                    {
                                        //-> md5 différent
                                        //-> télécharge fichier
                                        //todo: DownloadFile(nodeFile.SelectSingleNode("@url").InnerText, sFileFullPath);

                                        FileDownload fD = new FileDownload();

                                        fD.DownloadFile = sFileFullPath;
                                        fD.DownloadUrl = nodeFile.SelectSingleNode("@url").InnerText;
                                        fD.package = sName;

                                        Downloader.DownloadQueue.Add(fD);

                                        Console.WriteLine("DOWNLOAD: Update File " + nodeFile.SelectSingleNode("@path").InnerText + " from " + sFileLocalMD5 + " to " + sFileRemoteMD5);
                                    }
                                    else
                                    {
                                        // C'est good pour ce fichier !
                                    }

                                }

                            }

                            //Si erreur de verif on remplace la version par 0 dans le Package.xml sur le client
                            if ("erreur de verif des fichiers téléchargés" == "oui")
                            {

                            }
                            //deuxieme test au cas ou
                            else if ("test 2" == "ok")
                            {

                            }
                            //Si tout est OK, on remplace le package.xml local par celui du serveur
                            else
                            {
                                string sClientPackageXmlFile = Paths.GetLocalPackagesDir() + "\\" + ServerPackage.GetParam("folder") + "\\package.xml";


                                Console.WriteLine("Package File Update " + sClientPackageXmlFile);


                                XmlDocument ServerPackageXml = ServerPackage.GetXml();


                                //Create an XML declaration. 
                                XmlDeclaration xmldecl;
                                xmldecl = ServerPackageXml.CreateXmlDeclaration("1.0", "ISO-8859-1", null);

                                //Add the new node to the document.
                                XmlElement root = ServerPackageXml.DocumentElement;
                                ServerPackageXml.InsertBefore(xmldecl, root);

                                ServerPackageXml.Save(sClientPackageXmlFile);

                                //todo DownloadFile(http:\\server\packages\name\Package.xml, ComputePath("%PACKAGE%\Package.xml);
                            }


                            Console.WriteLine("Update de " + sName + " OK =)");
                        }
                        catch (Exception E)
                        {
                            Console.WriteLine("Update de " + sName + " KO =(");
                            Console.WriteLine(E.Message);
                        }
                        #endregion
                    }
                }

            }

            #endregion
        }



        public static void DoWork(bool doRequired = true, bool doUpdates = true)
        {
            //

            if (doRequired)
            {
                CheckRequiredPackages();
            }

            if (doUpdates)
            {
                CheckPackageUpdates();
            }

            
            if (Downloader.DownloadQueue.Count == 0)
            {
                return;
            }
            else
            {
                fUpdater.Show();
                fUpdater.backgroundWorker1.RunWorkerAsync();
                while (fUpdater.backgroundWorker1.IsBusy)
                {
                    Thread.Sleep(100);
                    Application.DoEvents();
                }
                fUpdater.Hide();                
            }


            try
            {
                ClientPackages.Get();
            }
            catch (PackagesGetException E)
            {
                throw E;
            }
            catch (Exception E)
            {
                throw E;
            }
        }

        
        public static void DoPackageInstall()
        {
            DoWork(true, false);
        }

        public static void DoPackageUpdates()
        {
            DoWork(false, true);
        }


        public static void DoTestLauncher()
        {
            bool test = true;

            string sLauncherDir = Paths.GetLocalPackagesDir() + "\\launcher";

            test = test && File.Exists(sLauncherDir + "\\DTCLauncher.exe");
            test = test && File.Exists(sLauncherDir + "\\DTCCommon.dll");

            if (!test)
            {
                //TODO: alerte: erreur launcher, veuiller supprimer le dossier launcher et relancer l'appli DansTonCube
                throw new Exception("Un fichier requis n'est pas présent, veuillez réinstaller le launcher.");
            }
        }


        /// <summary>
        /// Execute le launcher
        /// </summary>
        public static void DoStartLauncher()
        {
            Process P = new Process();
            P.StartInfo.FileName = Paths.GetLocalPackagesDir() + "\\launcher\\DTCLauncher.exe";
            P.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
            P.StartInfo.WorkingDirectory = Paths.GetLocalPackagesDir() + "\\launcher";
            //P.StartInfo.UseShellExecute = true;
            P.Start();
        }


        
        /// <summary>
        /// Lors du début d'un téléchargement
        /// </summary>
        /// <param name="d">Download qui débute</param>
        public static void downloader_OnDownloadStart(Download d)
        {
            
            //fUpdater.SetPackage(Path.GetFileName(Path.GetDirectoryName(d.DownloadFile)));

            //string toto = d.DownloadFile;
            //int inx = toto.IndexOf("\\", DTC.Common.Paths.GetLocalPackagesDir()));
            fUpdater.SetPackage(d.package);           
            fUpdater.SetLabel("Téléchargement de " + Path.GetFileName(d.DownloadFile));
        }

        /// <summary>
        /// Lors de la fin d'un téléchargement
        /// </summary>
        /// <param name="d">Download qui termine</param>
        public static void downloader_OnDownloadComplete(Download d)
        {
            // Trucs a faire apres le dl, genre verifs md5, decompression archive etc etc...
            switch (d.type)
            {
                case "package":


                    //decompression
                    try
                    {
                        fUpdater.SetPackage(d.package);
                        fUpdater.SetLabel("Décompression de " + Path.GetFileName(d.DownloadFile));

                        Ionic.Zip.ZipFile zipF = new Ionic.Zip.ZipFile(d.DownloadFile);
                        zipF.ExtractAll(Paths.GetLocalPackagesDir());
                    }
                    catch (Ionic.Zip.ZipException Z)
                    {
                        Console.WriteLine("ERREUR ZIP !");
                        Console.WriteLine(Z.Message);
                    }
                    catch (Exception E)
                    {
                        Console.WriteLine("ERREUR ZIP INCONNUE !");
                        Console.WriteLine(E.Message);
                    }

                    // verif MAj ? 

                    //ClientPackages.Get();
                    //Program.DoWork(false, true);
                    //

                    //todo: virer le .zip si ok ou si md5 incorrect

                    break;

                case "file":
                    //todo: verif MD5 ?
                    break;

                default:
                    //Inconnu ???
                    break;


            }



        }
        /// <summary>
        /// Lors d'une erreur de Download
        /// </summary>
        /// <param name="d">Download en erreur</param>
        public static void downloader_OnDownloadError(Download d)
        {
            Console.WriteLine("ERREUR DOWNLOAD !");
        }

        //Events WebClient (osef, ca sert juste pour fUpdater)
        public static void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
        }
        public static void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
        }




        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        static void Main(string[] args)
        {

            
            CheckIntegrity();


            bool skipmain = false;
            bool skiplauncher = false;
            bool skipwork = false;

            foreach (string arg in args)
            {
                if (arg.ToLower() == "skiplauncher")
                {
                    skiplauncher = true;
                }

                if (arg.ToLower() == "skipmain")
                {
                    skipmain = true;
                }
            }


#if DEBUG
            skipmain = true;
#endif

            //-> lance DTCMain.exe (ou "DTCLauncher.exe" une fois publié)
            if (!skipmain)
            {
                Process p = new Process();

                if (File.Exists(".\\DTCMain.exe"))
                {
                    p.StartInfo.FileName = ".\\DTCMain.exe";
                }
                else if (File.Exists(".\\DTCLauncher.exe"))
                {
                    p.StartInfo.FileName = ".\\DTCLauncher.exe";
                }
                else
                {
                    throw new Exception("Erreur: impossible de trouver DTCMain");
                }
               
                p.Start();
                return;
            }



        
           


            Application.EnableVisualStyles();




            /* Initialisation du Downloader */

            Downloader.Init();
            Downloader.DownloadProgress += new DownloadProgressChangedEventHandler(fUpdater.client_DownloadProgressChanged);
            Downloader.DownloadFileCompleted += new AsyncCompletedEventHandler(fUpdater.client_DownloadFileCompleted);
            Downloader.DownloadStarted += new Downloader.DownloadStartedEventHandler(fUpdater.downloader_DownloadStarted);
            Downloader.DownloadStarted += new Downloader.DownloadStartedEventHandler(downloader_OnDownloadStart);
            Downloader.DownloadFinished += new Downloader.DownloadFinishedEventHandler(downloader_OnDownloadComplete);
            Downloader.DownloadError += new Downloader.DownloadErrorEventHandler(downloader_OnDownloadError);




            /*Test et création si besoin des dossiers requis */

            //dossier "Packages"
            if (!Directory.Exists(Paths.GetLocalPackagesDir()))
            {
                try
                {
                    Directory.CreateDirectory(Paths.GetLocalPackagesDir());
                }
                catch
                {
                    MessageBox.Show("Impossible de créer les dossiers nécéssaires à l'instllation. Le programme ne peut pas s'installer.", "Erreur critique (PAckagesDir)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            //dossier "Temp"
            if (!Directory.Exists(Paths.GetLocalTempDir()))
            {
                try
                {
                    Directory.CreateDirectory(Paths.GetLocalTempDir());
                }
                catch
                {
                    MessageBox.Show("Impossible de créer les dossiers nécéssaires à l'instllation. Le programme ne peut pas s'installer.", "Erreur critique (TempDir)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }



            /*Lecture Packages.xml LOCAL */

            try
            {
                ClientPackages.Get();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message, "Erreur critique (ClientPackages.Get)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            /* Lectures Packages.xml SERVEUR */
            try
            {
                ServerPackages.Get();
            }
            catch (Exception E)
            {
                //MessageBox.Show(E.Message, "Erreur critique (ServerPackages.Get)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //return;

                skipwork = true;
            }
  


            /* Vérification & installation si paquets manquants obligatoires à installer */

            if (!skipwork)
            {
                //majs
                try
                {
                    DoPackageInstall();
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message, "Erreur critique (DoPackageInstall)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                /* Vérification & update si des mises à jour de paquets sont dispos */


                //updates
                try
                {
                    DoPackageUpdates();
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message, "Erreur critique (DoPackageUpdates)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



                //Mise à jour de Packages.xml LOCAL pour refleter les changements eventuels
                try
                {
                    ClientPackages.Packages.Version = ServerPackages.Packages.Version;
                    ClientPackages.Packages.MCVersion = ServerPackages.Packages.MCVersion;
                    ClientPackages.Set();
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message, "Erreur critique (ClientPackages.Set)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }


            if (skiplauncher)
            {
                return;
            }


            // test intégrité launcher ? 
            try
            {
                DoTestLauncher();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message, "Erreur critique (TestLauncher)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            //lancement launcher
            try
            {
                DoStartLauncher();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message, "Erreur critique (StartLauncher)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            //fin
            return;

        }








    }
}
