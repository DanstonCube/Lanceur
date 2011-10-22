using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Diagnostics;
using System.IO;

namespace DTC.Common
{

    public class ClientPackages
    {

        private static string sPackagesXmlFile = Paths.GetLocalPackagesXmlFile();

        internal static cPackages _packages = new cPackages();

        public static cPackages Packages
        {
            get
            {
                return _packages;
            }
        }


        public static int Count()
        {
            return _packages.GetPackages().Count;
        }


        public static implicit operator cPackages(ClientPackages p)
        {
            return _packages;
        }

        
        /// <throw>
        /// PackagesGetException
        /// </throw>
        public static void Get()
        {
            #if DEBUG
            #endif

            try
            {
                //Creation du fichier si inexistant
                if (!File.Exists(sPackagesXmlFile))
                {
                    InitXmlFile();
                }
                
                ClientPackages._packages._xml.Load(sPackagesXmlFile);


                //todo: scan packages
          
                string sClientPackagesDir = Paths.GetLocalPackagesDir();
                foreach (string dir in Directory.GetDirectories(sClientPackagesDir))
                {

                    string sPackageXmlFile =  dir + "\\package.xml";
                    if (!File.Exists(sPackageXmlFile))
                        continue;

                    XmlDocument xmlPackage = new XmlDocument();
                    xmlPackage.Load(sPackageXmlFile);
                    
                    //import du noeud <package> dans <packages>
                    XmlNode nodeImport = _packages._xml.ImportNode(xmlPackage.DocumentElement,true);
                    _packages._xml.DocumentElement.AppendChild(nodeImport);
                }




            }
            catch (FileNotFoundException E)
            {
                throw new PackagesSetException();
            }
            catch (XmlException E)
            {
                //erreur lecture: fichier xml corrumpu => recreation !
                throw new PackagesGetException();
            }
            catch (Exception E)
            {
                throw E;
            }

            Debug.Print(ClientPackages._packages._xml.OuterXml);

            return;
        }

        public static void Set()
        {

            foreach (XmlNode nodeToDelete in _packages._xml.DocumentElement.SelectNodes("//package"))
            {
                _packages._xml.DocumentElement.RemoveChild(nodeToDelete);
            }

            _packages._xml.Save(sPackagesXmlFile);
        }






        public static void InitXmlFile()
        {
            Packages._xml.LoadXml("<packages version='0' />");

            //try ecriture
            try
            {
                //todo: Paths.GetLocalPackagesXmlFile()
                Packages._xml.Save(Paths.GetLocalPackagesXmlFile());
            }
            catch (DirectoryNotFoundException E)
            {
                throw E;
            }
            catch (Exception E)
            {
                throw E;
            }
        }



        public static void DestroyXmlFile()
        {
            try
            {
                File.Delete("");
            }
            catch (Exception E)
            {
                
                throw E;
            }
        }


    }
}
