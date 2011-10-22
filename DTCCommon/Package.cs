using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace DTC.Common
{
    public class cPackage
    {
        XmlDocument _xml = new XmlDocument();



        public string Name
        {
            get
            {
                XmlNode t = _xml.SelectSingleNode("//name");
                if (t == null) return "";
                return t.InnerText;
            }
            set
            {
                _xml.SelectSingleNode("//name").InnerText = value;
            }
        }
        public string Label
        {
            get
            {
                XmlNode t = _xml.SelectSingleNode("//label");
                if (t == null) return "";
                return t.InnerText;
            }
            set
            {
                _xml.SelectSingleNode("//label").InnerText = value;
            }
        }        
        public string Version
        {
            get
            {
                XmlNode t = _xml.SelectSingleNode("//version");
                if (t == null) return "";
                return t.InnerText;
            }
            set
            {
                _xml.SelectSingleNode("//version").InnerText = value;
            }
        }

        public bool ForceInstall
        {
            get
            {
                string strTest = "";
                XmlNode nodeTest = _xml.SelectSingleNode("//force_install");
                if (nodeTest != null)   strTest = nodeTest.InnerText.ToLower();
                return (strTest == "1" || strTest == "true" || strTest == "yes");
            }
        }

        public void SetParam(string key, string value)
        {

            XmlNode nodeTest = _xml.SelectSingleNode("//" + key);

            if (nodeTest != null)
            {
                nodeTest.InnerText = value;
            }
            else
            {
                XmlNode nodeKey = _xml.CreateElement(key);
                nodeKey.InnerText = value;
                _xml.DocumentElement.AppendChild(nodeKey);
            }

        }

        public string GetParam(string key)
        {
            string retVal = "";
            XmlNode nodeTest = _xml.SelectSingleNode("//" + key);

            if (nodeTest != null)
            {
                retVal = nodeTest.InnerText;
            }

            return retVal;
        }



        public XmlDocument GetXml()
        {
            return _xml;
        }

        public XmlDocument LoadFromXmlFile(string FileName)
        {
            XmlDocument tempXml = new XmlDocument();
            tempXml.Load(FileName);
            return LoadFromXml(tempXml);
        }

        public XmlDocument LoadFromXml(string xmlPackage)
        {
            _xml.LoadXml(xmlPackage);
            return _xml;
        }
        public XmlDocument LoadFromXml(XmlDocument xmlPackage)
        {
            _xml = xmlPackage;
            return _xml;
        }


        // Override the ToString method to display an complex number in the suitable format:
        public override string ToString()
        {
            return this.Label;
        }

        public static implicit operator string(cPackage p)
        {
            return p.Label;
        }


    }




}
