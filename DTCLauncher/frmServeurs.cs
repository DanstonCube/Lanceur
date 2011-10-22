using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using DTC.Common;

namespace DTC
{
    public partial class frmServeurs : Form
    {
        public frmServeurs()
        {
            InitializeComponent();
        }

        private void LoadServerList()
        {
            lstServeurs.Items.Clear();
            foreach (XmlElement serveur in Config._config.SelectNodes("//serveur"))
            {
                string strServerName = serveur.GetAttribute("nom");
                lstServeurs.Items.Add(strServerName);
            }
        }

        private void LoadPackageList()
        {
            cboForcePackage.Items.Clear();
            foreach(cPackage p in ClientPackages.Packages.GetPackages())
            {
                if (p.GetParam("show_in_launcher") != "false")
                {
                    string pType = p.GetParam("type");
                    if (pType.ToLower() != "tool" && pType.ToLower() != "program")
                    {
                        cboForcePackage.Items.Add(p.Name);
                    }
                }
            }
        }

        private void frmServeurs_Load(object sender, EventArgs e)
        {
            LoadServerList();
            LoadPackageList();
        }

      

        private void btnSaveServeur_Click(object sender, EventArgs e)
        {
            string strNom = txtNom.Text.Trim();
            string strUrl = txtUrl.Text.Trim();
            string strPackage = ""; 

            if (strNom == "")
            {
                MessageBox.Show("Le nom du serveur ne peut pas être vide !");
                return;
            }

            if (strUrl == "")
            {
                MessageBox.Show("L'url du serveur ne peut pas être vide !");
                return;
            }

            if (chkForcePackage.Checked)
            {
                strPackage = cboForcePackage.Text;
            }



            //le serveur existe-il deja ?
            XmlElement server = (XmlElement)Config._config.SelectSingleNode("//serveur[@nom='" + strNom + "']");
            if (server != null)
            {
                server.SetAttribute("url", strUrl);
                server.SetAttribute("package", strPackage);
            }
            else
            {
                //rajout dans le xml
                XmlNode serveurs = Config._config.SelectSingleNode("//serveurs");
                XmlElement serveur = Config._config.CreateElement("serveur");
                serveur.SetAttribute("nom", strNom);
                serveur.SetAttribute("url", strUrl);
                serveur.SetAttribute("package", strPackage);
                serveurs.AppendChild(serveur);
            }

            Config.Save();
            LoadServerList();
        }

        private void btnLoadServeur_Click(object sender, EventArgs e)
        {
            string strNom = lstServeurs.Text;

            if (strNom == "")
            {
                MessageBox.Show("Vous devez choisir un serveur à éditer !");
                return;
            }

            //le serveur existe-il deja ?
            XmlElement serveur = (XmlElement)Config._config.SelectSingleNode("//serveur[@nom='" + strNom + "']");
            if (serveur != null)
            {
                string serverName = serveur.GetAttribute("nom");
                string serverUrl = serveur.GetAttribute("url");
                string serverPackage = serveur.GetAttribute("package");
                txtNom.Text = serverName;
                txtUrl.Text = serverUrl;


                if (serverPackage != "")
                {
                    chkForcePackage.Checked = true;
                    cboForcePackage.Enabled = true;

                    if (cboForcePackage.Items.IndexOf(serverPackage) >= 0)
                    {
                        cboForcePackage.SelectedItem = cboForcePackage.Items[cboForcePackage.Items.IndexOf(serverPackage)];
                    }
                    else
                    {
                        chkForcePackage.Checked = false;
                        cboForcePackage.Enabled = false;
                    }
                }
                else
                {
                    chkForcePackage.Checked = false;
                    cboForcePackage.Enabled = false;
                }

            }

        }

        private void btnDeleteServer_Click(object sender, EventArgs e)
        {
            string strNom = lstServeurs.Text;

            if (strNom == "")
            {
                MessageBox.Show("Vous devez choisir un serveur à supprimer !");
                return;
            }

            //l'utilisateur existe-il deja ?
            XmlElement user = (XmlElement)Config._config.SelectSingleNode("//serveur[@nom='" + strNom + "']");
            if (user != null)
            {
                Config._config.SelectSingleNode("//serveurs").RemoveChild(user);
                Config.Save();
                LoadServerList();
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void chkForcePackage_CheckedChanged(object sender, EventArgs e)
        {
            if (chkForcePackage.Checked)
            {
                cboForcePackage.Enabled = true;
            }
            else
            {
                cboForcePackage.Enabled = false;
            }
        }
    }
}
