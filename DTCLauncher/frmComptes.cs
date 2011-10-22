using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace DTC
{
    public partial class frmComptes : Form
    {
        public frmComptes()
        {
            InitializeComponent();
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkSavePass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSavePass.Checked)
            {
                txtPass.Enabled = true;
            }
            else
            {
                txtPass.Enabled = false;
            }
        }

        private void LoadAccountsList()
        {
            lstAccounts.Items.Clear();

            foreach (XmlElement compte in Config._config.SelectNodes("//account"))
            {
                string strAccountLogin = compte.GetAttribute("login");
                lstAccounts.Items.Add(strAccountLogin);
            }
        }

        private void frmConfig_Load(object sender, EventArgs e)
        {
            LoadAccountsList();
        }

        private void btnSaveAccount_Click(object sender, EventArgs e)
        {
            string strUser = txtUser.Text.Trim();
            string strPass = (chkSavePass.Checked) ? txtPass.Text : "";

            if (strUser == "")
            {
                MessageBox.Show("Le nom d'utilisateur ne peut pas être vide !");
                return;
            } 

            //l'utilisateur existe-il deja ?
            XmlElement user = (XmlElement)Config._config.SelectSingleNode("//account[@login='" + strUser + "']");
            if(user != null)
            {
                user.SetAttribute("pass",strPass);
            }
            else
            {
                //rajout dans le xml
                XmlNode comptes = Config._config.SelectSingleNode("//accounts");
                XmlElement compte = Config._config.CreateElement("account");
                compte.SetAttribute("login",strUser);
                compte.SetAttribute("pass",strPass);
                comptes.AppendChild(compte);
            }

            Config.Save();
            LoadAccountsList();
        }

        private void btnLoadAccount_Click(object sender, EventArgs e)
        {
            string strUser = lstAccounts.Text;

            if (strUser == "")
            {
                MessageBox.Show("Vous devez choisir un compte à éditer !");
                return;
            }

            //l'utilisateur existe-il deja ?
            XmlElement user = (XmlElement)Config._config.SelectSingleNode("//account[@login='" + strUser + "']");
            if (user != null)
            {
                string userLogin = user.GetAttribute("login");
                string userPass = user.GetAttribute("pass");

                txtUser.Text = userLogin;
                txtPass.Text = userPass;

                if (userPass == "")
                {
                    chkSavePass.Checked = false;
                    txtPass.Enabled = false;
                }
                else
                {
                    chkSavePass.Checked = true;
                    txtPass.Enabled = true;
                }

            }

        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            string strUser = lstAccounts.Text;

            if (strUser == "")
            {
                MessageBox.Show("Vous devez choisir un compte à supprimer !");
                return;
            }

            //l'utilisateur existe-il deja ?
            XmlElement user = (XmlElement)Config._config.SelectSingleNode("//account[@login='" + strUser + "']");
            if (user != null)
            {
                Config._config.SelectSingleNode("//accounts").RemoveChild(user);
                Config.Save();
                LoadAccountsList();
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
