using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace DTC
{
    class Config
    {
        public static XmlDocument _config = new XmlDocument();
        public static string _configfile = "";


        public static bool Save()
        {
            _configfile = Paths.GetSettingsPath();
            try
            {
                _config.Save(_configfile);
                return true;
            }
            catch
            {

            }
            return false;
        }

        public static bool Load()
        {
            _configfile = Paths.GetSettingsPath();
            try
            {
                _config.Load(_configfile);
            }catch{}
            
            if (Test()) return true;
           
            if (Reset()) return true;
            
            return false;
        }

        public static bool Test()
        {
            try
            {
                string testnode = "";
                testnode = _config.SelectSingleNode("//path").InnerText;
                testnode = _config.SelectSingleNode("//jarversion").InnerText;
                testnode = _config.SelectSingleNode("//mcversion").InnerText;
                testnode = _config.SelectSingleNode("//accounts").InnerText;
                testnode = _config.SelectSingleNode("//lastaccount").InnerText;
                testnode = _config.SelectSingleNode("//javapath").InnerText;

                //init config serveurs
                if (_config.SelectSingleNode("//serveurs") == null)
                {
                    XmlDocument xmlTempServList = new XmlDocument();
                    xmlTempServList.LoadXml(@"<serveurs/>");
                    XmlNode nServeurs = _config.ImportNode(xmlTempServList.DocumentElement, true);
                    _config.DocumentElement.AppendChild(nServeurs);
                }

                return true;
            }catch{}

            return false;
            
        }

        public static bool Reset()
        {
            //MessageBox.Show("Le fichier de configuration n'éxiste pas ou est invalide. Il va être créé");
            _config.LoadXml(@"
            <config>
                <accounts/>
                <serveurs/>
                <lastaccount/>
                <lastserv/>
                <jarversion/>
                <mcversion/>
                <path/>
                <javapath/>
                <autoclose>1</autoclose>
                <showskin>1</showskin>
            </config>
            ");
            return Save();
        }

        //path
        public static string GetPath()
        {
            return _config.SelectSingleNode("//path").InnerText;
        }
        public static void SetPath(string sPath)
        {
            _config.SelectSingleNode("//path").InnerText = sPath;
            Save();
        }

        //autoclose
        public static bool GetAutoClose()
        {
            string tmpStr = "";
            try
            {
                tmpStr = _config.SelectSingleNode("//autoclose").InnerText;
            }
            catch
            {
                tmpStr = "1";
                XmlElement nNode = _config.CreateElement("autoclose");
                nNode.InnerText = "1";
                _config.DocumentElement.AppendChild(nNode);
            }
            return tmpStr == "1";
        }
        public static void SetAutoClose(bool bValue)
        {
            if (_config.SelectSingleNode("//autoclose") == null)
            { 
                XmlElement nNode = _config.CreateElement("autoclose");
                nNode.InnerText = "1";
                _config.DocumentElement.AppendChild(nNode);
            }

            _config.SelectSingleNode("//autoclose").InnerText = (bValue) ?  "1" : "0";

            Save();
        }




        //simple
        public static bool GetSimple()
        {
            string tmpStr = "";
            try
            {
                tmpStr = _config.SelectSingleNode("//simple").InnerText;
            }
            catch
            {
                tmpStr = "1";
                XmlElement nNode = _config.CreateElement("simple");
                nNode.InnerText = "1";
                _config.DocumentElement.AppendChild(nNode);
            }
            return tmpStr == "1";
        }

        public static void SetSimple(bool bValue)
        {
            if (_config.SelectSingleNode("//simple") == null)
            {
                XmlElement nNode = _config.CreateElement("simple");
                nNode.InnerText = "1";
                _config.DocumentElement.AppendChild(nNode);
            }
            _config.SelectSingleNode("//simple").InnerText = (bValue) ? "1" : "0";
            Save();
        }


        //showads
        public static bool GetShowAds()
        {
            string tmpStr = "";
            try
            {
                tmpStr = _config.SelectSingleNode("//showads").InnerText;
            }
            catch
            {
                tmpStr = "0";
                XmlElement nNode = _config.CreateElement("showads");
                nNode.InnerText = "0";
                _config.DocumentElement.AppendChild(nNode);
            }
            return tmpStr == "1";
        }

        public static void SetShowAds(bool bValue)
        {
            if (_config.SelectSingleNode("//showads") == null)
            {
                XmlElement nNode = _config.CreateElement("showads");
                nNode.InnerText = "0";
                _config.DocumentElement.AppendChild(nNode);
            }
            _config.SelectSingleNode("//showads").InnerText = (bValue) ? "1" : "0";
            Save();
        }


        //showskin
        public static bool GetShowSkin()
        {
            string tmpStr = "";
            try
            {
                tmpStr = _config.SelectSingleNode("//showskin").InnerText;
            }
            catch
            {
                tmpStr = "1";
                XmlElement nNode = _config.CreateElement("showskin");
                nNode.InnerText = "1";
                _config.DocumentElement.AppendChild(nNode);
            }
            return tmpStr == "1";
        }

        public static void SetShowSkin(bool bValue)
        {
            if (_config.SelectSingleNode("//showskin") == null)
            {
                XmlElement nNode = _config.CreateElement("showskin");
                nNode.InnerText = "1";
                _config.DocumentElement.AppendChild(nNode);
            }
            _config.SelectSingleNode("//showskin").InnerText = (bValue) ? "1" : "0";
            Save();
        }


        //refreshskin
        public static bool GetRefreshSkin()
        {
            string tmpStr = "";
            try
            {
                tmpStr = _config.SelectSingleNode("//refreshskin").InnerText;
            }
            catch
            {
                tmpStr = "1";
                XmlElement nNode = _config.CreateElement("refreshskin");
                nNode.InnerText = "0";
                _config.DocumentElement.AppendChild(nNode);
            }
            return tmpStr == "1";
        }

        public static void SetRefreshSkin(bool bValue)
        {
            if (_config.SelectSingleNode("//refreshskin") == null)
            {
                XmlElement nNode = _config.CreateElement("refreshskin");
                nNode.InnerText = "1";
                _config.DocumentElement.AppendChild(nNode);
            }
            _config.SelectSingleNode("//refreshskin").InnerText = (bValue) ? "1" : "0";
            Save();
        }




        //lastserv
        public static string GetLastServ()
        {
            string tmpStr = "";
            try
            {
                tmpStr = _config.SelectSingleNode("//lastserv").InnerText;
            }
            catch
            {
                XmlElement nNode = _config.CreateElement("lastserv");
                nNode.InnerText = "";
                _config.DocumentElement.AppendChild(nNode);
            }
            return tmpStr;
        }

        public static void SetLastServ(string sValue)
        {
            if (_config.SelectSingleNode("//lastserv") == null)
            {
                XmlElement nNode = _config.CreateElement("lastserv");
                nNode.InnerText = sValue;
                _config.DocumentElement.AppendChild(nNode);
            }

            _config.SelectSingleNode("//lastserv").InnerText = sValue;
            Save();
        }

        //lastpackage
        public static string GetLastPackage()
        {
            string tmpStr = "";
            try
            {
                tmpStr = _config.SelectSingleNode("//lastpackage").InnerText;
            }
            catch
            {
                XmlElement nNode = _config.CreateElement("lastpackage");
                nNode.InnerText = Program.defaultpackage;
                _config.DocumentElement.AppendChild(nNode);
            }
            return tmpStr;
        }

        public static void SetLastPackage(string sValue)
        {
            if (_config.SelectSingleNode("//lastpackage") == null)
            {
                XmlElement nNode = _config.CreateElement("lastpackage");
                nNode.InnerText = sValue;
                _config.DocumentElement.AppendChild(nNode);
            }

            _config.SelectSingleNode("//lastpackage").InnerText = sValue;
            Save();
        }




        //getMem
        public static string GetJavaMemory()
        {
            string tmpStr = "";
            try
            {
                tmpStr = _config.SelectSingleNode("//javamemory").InnerText;
            }
            catch
            {
                XmlElement nNode = _config.CreateElement("javamemory");
                nNode.InnerText = "1024";
                _config.DocumentElement.AppendChild(nNode);
            }
            return tmpStr;
        }

        //setMem
        public static void SetJavaMemory(string sValue)
        {
            if (_config.SelectSingleNode("//javamemory") == null)
            {
                XmlElement nNode = _config.CreateElement("javamemory");
                nNode.InnerText = sValue;
                _config.DocumentElement.AppendChild(nNode);
            }

            _config.SelectSingleNode("//javamemory").InnerText = sValue;
            Save();
        }







        //javapath
        public static string GetJavaPath()
        {
            return _config.SelectSingleNode("//javapath").InnerText;
        }
        public static void SetJavaPath(string sJavaPath)
        {
            _config.SelectSingleNode("//javapath").InnerText = sJavaPath;
            Save();
        }

        //lastaccount
        public static string GetLastaccount()
        {
            return _config.SelectSingleNode("//lastaccount").InnerText;
        }
        public static void SetLastAccount(string sAccount)
        {
            _config.SelectSingleNode("//lastaccount").InnerText = sAccount;
            Save();
        }






        /*
        //jarversion
        public static string GetJarVersion()
        {
            return _config.SelectSingleNode("//jarversion").InnerText;
        }
        public static void SetJarVersion(string sJarVersion)
        {
            _config.SelectSingleNode("//jarversion").InnerText = sJarVersion;
            Save();
        }

        //mcversion
        public static string GetMcVersion()
        {
            return _config.SelectSingleNode("//mcversion").InnerText;
        }
        public static void SetMcVersion(string sMcVersion)
        {
            _config.SelectSingleNode("//mcversion").InnerText = sMcVersion;
            Save();
        }
        */





    }
}
