#define HTTP

using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading;



namespace DTC.Common
{
   

    public class ServerPackages
    {

#if HTTP
        private static string sPackagesUrl = "http://www.danstoncube.com/launcher/Packages/packages.xml";
#else
        private static string sPackagesFile = "D:\\DOCZ\\My Dropbox\\DEV\\DansTonCube\\DansTonCube\\SERVEURDEV\\Packages\\packages.xml";
#endif


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
            return Packages.GetPackages().Count;
        }


        public static implicit operator cPackages(ServerPackages p)
        {
            return Packages;
        }


        /// <throw>
        /// PackagesGetException
        /// </throw>
        public static void Get()
        {
            try
            {

#if HTTP
                string sPackagesXml = "";

                WebClient client = new WebClient();
                client.Encoding = ASCIIEncoding.ASCII;

                try
                {
                    sPackagesXml = client.DownloadString(sPackagesUrl);
                }
                catch (WebException W)
                {
                    throw W;
                }
                catch (Exception E)
                {
                    throw E;
                }

                ServerPackages._packages._xml.LoadXml(sPackagesXml);

#else
                ServerPackages._packages._xml.Load(sPackagesFile);
#endif

            }
            catch (XmlException E)
            {
                Debug.Print(E.Message);
                throw E;
            }
            catch (Exception E)
            {
                Debug.Print(E.Message);
                throw new PackagesGetException();
            }

            Debug.Print(Packages._xml.OuterXml);

            return;
        }



        //event OnGetPackagesComplete ?
        //event OnGetPackagesError ?



    }
}
