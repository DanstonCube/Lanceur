using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Net;
using DTC.Common;

namespace DTC
{
    static class Program
    {
        /* Variables */
        public static bool dev = false;
        public static bool serveronline = false;
        public static int playersonline = 0;
        public static XmlDocument xmlstaticservers = new XmlDocument();

        //deprecated
        public static string dtchttpversion = "";
        public static string serverurl = "danstoncube.com";

        /* Constantes du launcher */

        public static string mcversion = "1316075312000";
        public static string defaultpackage = "minecraft";
        public static string dtcversion = "1.2.0.4";
        
        //page web de niouze a afficher
        public static string htmlpageurl = "http://www.danstoncube.com/twitter/index.php";        
                
        //url des infos de dynmap (peut etre pointé sur autre chose, mais il faudra adapter le parser de resultats
        public static string serverinfourl = "http://dynmap.danstoncube.com/standalone/dynmap_Bisounours.json";  
                
        //liste en dur des serveurs
        public static string serversxml = @"
        <serveurs>
            <serveur nom='DansTonCube !' url='88.190.243.31' package='dtc181' />
            <serveur nom='TuPeuxPasTest ! (freebuild)' url='88.190.243.31:25566' package='dtc181' />
        </serveurs>
        ";
        


        public static string skinurl = "http://www.danstoncube.com/launcher/skin32.php?user={0}&refresh=1";



        /// <summary>
        /// Charge la configuration et vérifie que celle ci est chargée
        /// </summary>
        /// <returns>True/False</returns>
        public static bool CheckConfig()
        {
            return Config.Load();
        }

        /// <summary>
        /// Vérifie qu'au moins un compte est configuré
        /// </summary>
        /// <returns>True/False</returns>
        public static bool CheckAccount()
        {
            int nbAccounts = Config._config.SelectNodes("//account").Count;
            if (nbAccounts > 0) return true;
            return false;
        }


        public static void RunPackage(string sPackage)
        {
            string sPackageFolder = ClientPackages.Packages.GetPackage(sPackage).GetParam("folder");
            string sPackagePath = DTC.Common.Paths.GetRootDTC() + "\\Packages\\" + sPackageFolder;
            bool isMinecraft = Minecraft.IsValidMinecraftInstall(sPackagePath);

        }






        /// <summary>
        /// Lance un paquet de type Minecraft avec les paramètres autologin ou non suivant si ceux ci sont fournis.
        /// </summary>
        /// <param name="sPackage">Nom du paquet</param>
        /// <param name="sUser">User pour le login auto</param>
        /// <param name="sPass">Pass pour le login auto</param>
        /// <param name="sServer">Serveur pour la connexion auto (si user & pass renseignés)</param>
        public static void RunMinecraft(string sPackage, string sUser="", string sPass="", string sServer="")
        {
            //préparation parametres autologin à passer au .bat 
            //(user,pass,serveur), seulement si password renseigné
            string sBatchParameters = "";
            if (sPass != "")
            {
                sBatchParameters = sUser + " " + sPass + " " + ((sServer == "") ? Program.serverurl : sServer);
            }


            //Détermination du paquet Minecraft à prendre
            string sPackageFolder = ClientPackages.Packages.GetPackage(sPackage).GetParam("folder");
            string sParamForceMCVersion = ClientPackages.Packages.GetPackage(sPackage).GetParam("force_mcversion").ToLower();
            string sPackagePath = DTC.Common.Paths.GetRootDTC() + "\\Packages\\" + sPackageFolder;


            //Verifie que le paquet contient une install minecraft valide !!!
            bool IsValidMinecraftFolder = Minecraft.IsValidMinecraftInstall(sPackagePath); 
            bool bParamForceMCVersion = (sParamForceMCVersion == "true" || sParamForceMCVersion == "1" ||sParamForceMCVersion == "yes" || sParamForceMCVersion == "y");            
            
            if (IsValidMinecraftFolder && bParamForceMCVersion)
            {
                //Doit-on patcher le fichier version pour empêcher la demande de mise à jour ?
                string strVersion = Minecraft.GetMinecraftVersion(sPackagePath);
                if (strVersion != Program.mcversion)
                {
                    Int64 v1 = 0;
                    Int64 v2 = 0;

                    if (Int64.TryParse(strVersion, out v1) && Int64.TryParse(Program.mcversion, out v2))
                    {
                        //!!! On patche uniquement si le MCVersion de notre programme est plus élevée que celle du paquet !!!
                        if (v2 > v1)
                        {
                            //Patche le fichier MCVersion du paquet avec la notre
                            Minecraft.SetMinecraftVersion(sPackagePath, Program.mcversion);
                        }
                    }
                }
            }

            string runcmd = ClientPackages.Packages.GetPackage(sPackage).GetParam("run");

            if(runcmd == "")
            {
                //CREE le .bat pour le changement du APPDATA
                Program.MakeBatchFile(".\\run.bat", sPackagePath);
            }
            else
            {
                //COMMANDE PERSONALISEE POUR LE LANCEMENT
                runcmd = DTC.Common.Paths.ComputePath(runcmd,sPackage);
                File.WriteAllText(".\\run.bat",runcmd.Replace("\t",""));
            }

            //LANCE le .bat avec les paramètres
            Program.RunBatchFile(".\\run.bat", sBatchParameters);

            //SUPPRIME le .bat
            File.Delete(".\\run.bat");
        }



        /// <summary>
        /// Lance la version originale de minecraft si celle si est présente sur l'ordinateur
        /// </summary>
        /// <param name="sUser">User pour le login auto</param>
        /// <param name="sPass">Pass pour le login auto</param>
        /// <param name="sServer">Srveur pour la connexion auto (nécessite de renseigner le user & password)</param>
        public static void RunOriginalMinecraft(string sUser="",string sPass="", string sServer="")
        {
            //parametres à passer au .bat (user,pass,serveur)
            string sBatchParameters = "";
            if (sPass != "")
            {
                sBatchParameters = sUser + " " + sPass + " " + ((sServer == "") ? Program.serverurl : sServer);
            }

            Program.MakeMCBatchFile(".\\run.bat", DTC.Common.Paths.GetLocalPackagesDir() + "\\minecraft");
            Program.RunBatchFile(".\\run.bat", sBatchParameters);
            File.Delete(".\\run.bat");
        }

        

        /// <summary>
        /// Construit le fichier de commande 'commandfile' avec les parametres donnés pour une version a part de Minecraft (paquet)
        /// </summary>
        /// <param name="commandfile">Fichier de commande à créer</param>
        /// <param name="appdatapath">Chemin Appdata du paquet minecraft</param>
        /// <param name="javapath">Chemin vers javaw.exe</param>
        /// <param name="javaparameters">Paramètres Java du lanceur</param>
        public static void MakeBatchFile(string commandfile, string appdatapath, string javapath="", string javaparameters="")
        {
            string sCommands = "";
            sCommands += "set APPDATA={1}\r\n";
            //toto += "cd \"{1}\\DTC\"\r\n";

            //TODO: Ajout paramètres customisés
            //sCommands += "start \"Minecraft\" /D \"{1}\" /B \"{0}\" -jar -Dsun.java2d.noddraw=true -Dsun.awt.noerasebackground=true -Dsun.java2d.d3d=false -Dsun.java2d.opengl=true -Dsun.java2d.pmoffscreen=true -Xms1G -Xmx1G launcher.jar %1 %2 %3\r\n";

            int iMem = 1024;
            string mem = "-Xms256M -Xmx1G";
            if (int.TryParse(Config.GetJavaMemory(), out iMem))
            {

                string sMem = "m";
                if (iMem > 1024)
                {
                    iMem = iMem / 1024;
                    sMem = "G";
                }
                
                mem = String.Format("-Xms256M -Xmx{0}{1}", iMem,sMem);
            }

            sCommands += "start \"Minecraft\" /D \"{1}\" /B \"{0}\" -jar {2} launcher.jar %1 %2 %3\r\n";
            sCommands = String.Format(sCommands, GetJavaBinPath(), appdatapath, mem);
            File.WriteAllText(commandfile, sCommands);
        }




        /// <summary>
        /// Construit le fichier de commande 'commandfile' avec les parametres donnés pour la version originale de Minecraft
        /// </summary>
        /// <param name="commandfile">Fichier de commande à créer</param>
        /// <param name="appdatapath">Répertoire contenant launcher.jar</param>
        public static void MakeMCBatchFile(string commandfile, string appdatapath)
        {
            string sCommands = "";
            sCommands += "start \"Minecraft\" /D \"{1}\" /B \"{0}\" -jar launcher.jar %1 %2 %3\r\n";
            sCommands = String.Format(sCommands, GetJavaBinPath(), appdatapath);
            File.WriteAllText(commandfile, sCommands);
        }






        /// <summary>
        /// Execute un fichier bat avec des parametres ou pas, en cachant l'invite de commande
        /// </summary>
        /// <param name="commandfile">Fichier .bat à lancer</param>
        /// <param name="parameters">Arguments à passer au .bat</param>
        public static void RunBatchFile(string commandfile, string parameters="")
        {
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo(commandfile);
            startInfo.CreateNoWindow = true;
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;

            if (parameters != "")
            {
                startInfo.Arguments = parameters;
            }
            Process p = new Process();

            try
            {
                p.StartInfo = startInfo;
                p.Start();
            }
            catch
            {
            }
                
            while (!p.HasExited)
            {
                Thread.Sleep(10);
                Application.DoEvents();
            }

            startInfo = null;
        }


        /// <summary>
        /// Lit le chemin vers Java dans la config. 
        /// Si celui si n'existe pas dans la config, recherche de JAVA
        /// </summary>
        /// <returns>Chemin complet vers javaw.exe</returns>
        public static string GetJavaBinPath()
        {

            string strJavaBin = "";
            
            try
            {
                strJavaBin = Config.GetJavaPath();
            }
            catch{
            }

            if (strJavaBin != "") return strJavaBin;
            else
            {
                string strJavaBinLocate = Java.LocateJava();
                return strJavaBinLocate + "javaw.exe";
            }
        }


        /// <summary>
        /// Pour ouvrir une adresse web sur le navigateur du client
        /// </summary>
        /// <param name="url">Adresse à ouvrir dans le navigateur par défaut du système</param>
        public static void NavigateUrl(string url)
        {
            try
            {
                System.Diagnostics.Process.Start(url);
            }
            catch (Exception exc1)
            {
                if (exc1.GetType().ToString() != "System.ComponentModel.Win32Exception")
                {
                    try
                    {
                        System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo("IExplore.exe", url);
                        System.Diagnostics.Process.Start(startInfo);
                        startInfo = null;
                    }
                    catch
                    {
                    }
                }
            } 
        }


       


    }
}
