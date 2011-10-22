using System;
using System.Text;
using System.Xml;
using System.Collections.ObjectModel;

using DTC.Common;

namespace DTC
{
    public class cPackages
    {
        public XmlDocument _xml = new XmlDocument();

        public string Version
        {
            get
            {
                XmlNode nodeVersion =   _xml.DocumentElement.SelectSingleNode("@version");
                if(nodeVersion==null)   _xml.DocumentElement.SetAttribute("version", "0");                
                return _xml.DocumentElement.GetAttribute("version");
            }
            set
            {
                _xml.DocumentElement.SetAttribute("version", value);
            }
        }

        public string MCVersion
        {
            get
            {
                XmlNode nodeVersion = _xml.DocumentElement.SelectSingleNode("@mcversion");
                if (nodeVersion == null) _xml.DocumentElement.SetAttribute("mcversion", "0");
                return _xml.DocumentElement.GetAttribute("mcversion");
            }
            set
            {
                _xml.DocumentElement.SetAttribute("mcversion", value);
            }
        }

        public Collection<cPackage> GetPackages()
        {

            Collection<cPackage> retList = new Collection<cPackage>();

            foreach (XmlNode nodePackage in _xml.SelectNodes("//package"))
            {
                cPackage newPackage = new cPackage();
                newPackage.LoadFromXml(nodePackage.OuterXml);
                retList.Add(newPackage);
            }

            return retList;
           
        }

        public cPackage GetPackage(string name)
        {
            foreach (XmlNode nodePackage in _xml.SelectNodes("//package"))
            {
                cPackage newPackage = new cPackage();
                newPackage.LoadFromXml(nodePackage.OuterXml);
                if (newPackage.Name == name) return newPackage;
            }
            return null;
        }


        public static implicit operator Collection<cPackage>(cPackages p)
        {
            return p.GetPackages();
        }




    }



}
