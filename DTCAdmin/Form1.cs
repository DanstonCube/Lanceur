using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DTC.Common;
using System.IO;
using System.Xml;

namespace DTCAdmin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loading = true;

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



            txtPackagesFile.SelectionStart = txtPackagesFile.Text.Length;
            txtPackagesFile.SelectionLength = 0;

            tabPackages.TabPages.Clear();

            /*
            foreach (string folder in Directory.GetDirectories(txtPackagesFile.Text))
            {
                if(!File.Exists(folder + "\\package.xml")) continue;

                tabPackages.TabPages.Add(Path.GetFileName(folder), Path.GetFileName(folder));



            }
            */
            
            ServerPackages.Packages._xml.Load(txtPackagesFile.Text + "\\packages.xml");
            foreach (cPackage p in ServerPackages.Packages.GetPackages())
            {
                tabPackages.TabPages.Add(p.Name, p.Name);
                tabPackages.SelectedTab = tabPackages.TabPages[tabPackages.TabPages.Count - 1];
                //LoadPackage(p.Name);
            }
           

            tabPackages.SelectedTab = tabPackages.TabPages["launcher"];
            LoadPackage("launcher");


            loading = false;
        }

       

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }


        private void LoadPackage(string name)
        {
            loading = true;
            cPackage p = ServerPackages.Packages.GetPackage(name);



            txtName.Text = p.Name;
            txtLabel.Text = p.Label;
            txtFolder.Text = p.GetParam("folder");
            txtArchive.Text = p.GetParam("archive");
            txtUrl.Text = p.GetParam("download_url");
            txtIcon.Text = p.GetParam("icon");
            txtRun.Text = p.GetParam("run");

            numericVersion.Value = int.Parse(p.Version);

            chkOptionnal.Checked = p.GetParam("optional") != "false";
            chkForceInstall.Checked = p.GetParam("force_install") == "true";
            chkShowInLauncher.Checked = p.GetParam("show_in_launcher") != "false";



            XmlDocument xmlPackage = p.GetXml();
            
            listViewFiles.Items.Clear();

            bool everything_ok = true;

            foreach (XmlElement fileElem in xmlPackage.SelectNodes("//file"))
            {


                string strlocalfile = fileElem.GetAttribute("path");
                strlocalfile = strlocalfile.Replace("%PACKAGE%", txtPackagesFile.Text + "\\" + p.GetParam("folder"));

                string strlocalfilemd5 = MD5.GetMD5HashFromFile(strlocalfile);


                //strlocalfile = strlocalfile.Replace("%PACKAGE%", "");





                ListViewItem newItem = new ListViewItem();
                newItem.Text = fileElem.GetAttribute("path");
                newItem.SubItems.Add(fileElem.GetAttribute("url").Replace("http://www.danstoncube.com/launcher/Packages/",""));
                newItem.SubItems.Add(fileElem.GetAttribute("md5"));
                newItem.SubItems.Add(strlocalfilemd5);

                if(fileElem.GetAttribute("md5")!=strlocalfilemd5)   
                {
                    newItem.BackColor = Color.Red;
                    everything_ok = false;
                }
                else
                {
                    newItem.BackColor = Color.Green;
                }

                listViewFiles.Items.Add(newItem);
            }





            if (p.GetParam("type") != "")
            {
                cboType.SelectedItem = p.GetParam("type");
            }
            else
            {
                cboType.Text = "";
            }


            if (everything_ok)
            {
                tabPackages.SelectedTab.ImageIndex = 1;
            }
            else
            {
                tabPackages.SelectedTab.ImageIndex = 0;
            }

            loading = false;
        }

        private void tabPackages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabPackages.SelectedTab == null) return;

            LoadPackage(tabPackages.SelectedTab.Text);
        }


        bool loading = false;
        private void SetCurrentPackageParam(string param, string value)
        {
            if (loading) return;
            if (tabPackages.SelectedTab == null) return;

            XmlNode nodePackage = ServerPackages.Packages._xml.SelectSingleNode("//name[.='" + tabPackages.SelectedTab.Text + "']").ParentNode;

            if (nodePackage == null) return;

            XmlNode nodeParam = nodePackage.SelectSingleNode("./" + param);

            if (nodeParam == null)
            {
                nodeParam = ServerPackages.Packages._xml.CreateElement(param);
                nodePackage.AppendChild(nodeParam);
            }

            nodeParam.InnerText = value;
        }

        private void SetCurrentPackageParamCDATA(string param, string value)
        {
            if (loading) return;
            if (tabPackages.SelectedTab == null) return;

            XmlNode nodePackage = ServerPackages.Packages._xml.SelectSingleNode("//name[.='" + tabPackages.SelectedTab.Text + "']").ParentNode;

            if (nodePackage == null) return;

            XmlNode nodeParam = nodePackage.SelectSingleNode("./" + param);

            if (nodeParam == null)
            {
                XmlCDataSection nodeCdata = ServerPackages.Packages._xml.CreateCDataSection(value);
                nodeParam = ServerPackages.Packages._xml.CreateElement(param);
                nodePackage.AppendChild(nodeParam);
                nodeParam.AppendChild(nodeCdata);
            }
            else
            {
                nodeParam.FirstChild.InnerText = value;
            }
            //nodeParam.InnerText = value;
        }


        private void cboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetCurrentPackageParam("type", cboType.Text);
        }


        private void txtArchive_TextChanged(object sender, EventArgs e)
        {
            SetCurrentPackageParam("archive", txtArchive.Text);
        }

        private void txtIcon_TextChanged(object sender, EventArgs e)
        {
            SetCurrentPackageParam("icon", txtIcon.Text);
        }

        private void txtUrl_TextChanged(object sender, EventArgs e)
        {
            SetCurrentPackageParam("download_url", txtUrl.Text);
        }

        private void txtFolder_TextChanged(object sender, EventArgs e)
        {
            SetCurrentPackageParam("folder", txtFolder.Text);
        }

        private void txtLabel_TextChanged(object sender, EventArgs e)
        {
            SetCurrentPackageParam("label", txtLabel.Text);
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            SetCurrentPackageParam("name", txtName.Text);
        }

        private void numericVersion_ValueChanged(object sender, EventArgs e)
        {
            SetCurrentPackageParam("version", numericVersion.Value.ToString());
        }

        private void txtRun_TextChanged(object sender, EventArgs e)
        {
            SetCurrentPackageParamCDATA("run", txtRun.Text);
        }

        private void chkOptionnal_CheckedChanged(object sender, EventArgs e)
        {
            string value = (chkOptionnal.Checked) ? "true" : "false";
            SetCurrentPackageParam("optional", value);

        }

        private void chkForceInstall_CheckedChanged(object sender, EventArgs e)
        {
            string value = (chkForceInstall.Checked) ? "true" : "false";
            SetCurrentPackageParam("force_install", value);
        }

        private void chkShowInLauncher_CheckedChanged(object sender, EventArgs e)
        {
            string value = (chkForceInstall.Checked) ? "true" : "false";
            SetCurrentPackageParam("show_in_launcher", value);
        }

        private void btnUpdateMD5s_Click(object sender, EventArgs e)
        {

            //maj des md5 dans le fichier xml


            if (tabPackages.SelectedTab == null) return;

            cPackage p = ServerPackages.Packages.GetPackage(tabPackages.SelectedTab.Text);
            if (p == null) return;

            XmlDocument xmlPackage = p.GetXml();
            foreach (XmlElement fileElem in xmlPackage.SelectNodes("//file"))
            {
                string strlocalfile = fileElem.GetAttribute("path");
                strlocalfile = strlocalfile.Replace("%PACKAGE%", txtPackagesFile.Text + "\\" + p.GetParam("folder"));

                if (!File.Exists(strlocalfile))
                {
                    MessageBox.Show("Attention, le fichier " + strlocalfile + " n'a pas été trouvé en local !");
                    continue;
                }


                string strlocalfilemd5 = MD5.GetMD5HashFromFile(strlocalfile);

                string strPath = fileElem.GetAttribute("path");
                string strUrl = fileElem.GetAttribute("url").Replace("http://www.danstoncube.com/launcher/Packages/", "");
                string strMd5 = fileElem.GetAttribute("md5");
                string strMd5Local = strlocalfilemd5;


                if (strMd5 != strMd5Local)
                {
                    //mise a jour du xml serveur

                    XmlNode nodePackage = ServerPackages.Packages._xml.SelectSingleNode("//name[.='" + tabPackages.SelectedTab.Text + "']").ParentNode;

                    if (nodePackage == null) continue;

                    XmlNode nodeFile = nodePackage.SelectSingleNode(".//file[@path='" + strPath + "']");

                    if (nodeFile == null) continue;

                    ((XmlElement)nodeFile).SetAttribute("md5", strMd5Local);
                }

            }



            LoadPackage(tabPackages.SelectedTab.Text);
        }

        private void btnSaveXml_Click(object sender, EventArgs e)
        {
            //ServerPackages.Packages._xml.Save(

            
            if(!File.Exists(txtPackagesFile.Text + "\\Packages.xml")) return;
            
            File.Copy(txtPackagesFile.Text + "\\Packages.xml", txtPackagesFile.Text + "\\packages_" + DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + "_" + DateTime.Now.Hour.ToString() + "." + DateTime.Now.Minute.ToString() + "." + DateTime.Now.Second.ToString() + ".xml");



            ServerPackages.Packages._xml.Save(txtPackagesFile.Text + "\\Packages.xml");
            ServerPackages.Get();

            Form1_Load(this,new EventArgs());



        }

        private void btnExportPackageXml_Click(object sender, EventArgs e)
        {
            if (tabPackages.SelectedTab == null) return;
            cPackage p = ServerPackages.Packages.GetPackage(tabPackages.SelectedTab.Text);
            if (p == null) return;

            XmlDocument xmlPackageOut = new XmlDocument();

            XmlNode nodeDeclaration = ServerPackages.Packages._xml.FirstChild;
            if(nodeDeclaration == null) return;
            XmlNode nodeDeclarationImport = xmlPackageOut.ImportNode(nodeDeclaration, false);
            

            XmlNode nodePackage = ServerPackages.Packages._xml.SelectSingleNode("//name[.='" + p.Name + "']").ParentNode;
            if (nodePackage == null) return;
            XmlNode nodePackageImport = xmlPackageOut.ImportNode(nodePackage, true);



            xmlPackageOut.AppendChild(nodeDeclarationImport);
            xmlPackageOut.AppendChild(nodePackageImport);

            string strLocalPackageFile = txtPackagesFile.Text + "\\" + p.Name + "\\package.xml";
            if (File.Exists(strLocalPackageFile))
            {
                string strFileDest = txtPackagesFile.Text + "\\package_" + DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + "_" + DateTime.Now.Hour.ToString() + "." + DateTime.Now.Minute.ToString() + "." + DateTime.Now.Second.ToString() + ".xml";
                File.Copy(strLocalPackageFile, strFileDest);
            }


            xmlPackageOut.Save(strLocalPackageFile);

        }

        private void btnIncrementVersion_Click(object sender, EventArgs e)
        {
            numericVersion.Value++;
        }

        

       


    }
}
