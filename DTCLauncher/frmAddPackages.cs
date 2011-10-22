using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DTC.Common;
using System.Xml;
using System.IO;

namespace DTC
{
    public partial class frmAddPackages : Form
    {
        public frmAddPackages()
        {
            InitializeComponent();
        }

        private void frmAddPackages_Load(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            foreach (cPackage p in ServerPackages.Packages.GetPackages())
            {
                cPackage pL = ClientPackages.Packages.GetPackage(p.Name);

                if (pL == null)
                {
                    ListViewItem newItem = new ListViewItem();

                    newItem.Text = p.Name;
                    newItem.SubItems.Add(p.Label);
                    newItem.SubItems.Add(p.GetParam("type"));
                    listView1.Items.Add(newItem);

                }

            }

            if (listView1.Items.Count == 0)
            {
                MessageBox.Show("Aucun paquet(s) facultatif(s) disponible(s) !");
                this.Close();
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.Items)
            {
                if (!item.Checked) continue;

                cPackage serverPackage = ServerPackages.Packages.GetPackage(item.Text);
                if (serverPackage == null) continue;
                if (serverPackage.GetParam("folder") == "") continue;

                //generation d'un mini package.xml pour l'install
                string packagexml = @"
                <package>
                    <name>{0}</name>
                    <label>{1}</label>
                    <version>0</version>                    
                    <install>true</install>
                </package>
                ";

                packagexml = String.Format(packagexml, serverPackage.Name, serverPackage.Label);

                XmlDocument xmlPackage = new XmlDocument();
                try
                {
                    xmlPackage.LoadXml(packagexml);
                }
                catch
                {
                    continue;
                }

                string packagefolder = DTC.Common.Paths.GetLocalPackagesDir() + "\\" + serverPackage.GetParam("folder");
                if(!Directory.Exists(packagefolder))
                {
                    Directory.CreateDirectory(packagefolder);
                }

                xmlPackage.Save(packagefolder + "\\package.xml");
            }

            this.Close();
        }
    }
}
