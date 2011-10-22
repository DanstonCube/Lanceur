using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace DTC
{
    public partial class frmConfig : Form
    {
        public frmConfig()
        {
            InitializeComponent();
        }


        public bool bModifs = false;

        private void frmConfig_Load(object sender, EventArgs e)
        {
            chkAutoClose.Checked = Config.GetAutoClose();
            txtJavaPath.Text = Config.GetJavaPath();


            optSimpleMode.Checked = Config.GetSimple();
            optAdvancedMode.Checked = !optSimpleMode.Checked;

            chkShowSkin.Checked = Config.GetShowSkin();
            chkShowAds.Checked = Config.GetShowAds();

            int iMem = 1024;
            numMemory.Value = int.TryParse(Config.GetJavaMemory(), out iMem) ? iMem : 1024;

            //txtPath.Text = Config.GetPath();
                 
        }

        private void cmdFindJava_Click(object sender, EventArgs e)
        {
            string strTmpJavaPath = "";
            if (File.Exists(txtJavaPath.Text))
            {
                strTmpJavaPath = Path.GetDirectoryName(txtJavaPath.Text);
                dlgFindJava.InitialDirectory = strTmpJavaPath;
            }
            else
            {
                dlgFindJava.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
            }


            DialogResult result = dlgFindJava.ShowDialog();

            if (result != System.Windows.Forms.DialogResult.OK)
            {

                return;
            }

            txtJavaPath.Text = dlgFindJava.FileName;

            bModifs = true;



        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (bModifs)
            {

                //TODO: tester le chemin de java
                //TODO: calculer les paramètres mémoire JAVA
                //TODO: verif taille memoire java

                //Si tout ok:
                Config.SetJavaPath(txtJavaPath.Text);
                Config.SetAutoClose(chkAutoClose.Checked);
                Config.SetSimple(optSimpleMode.Checked);
                Config.SetShowAds(chkShowAds.Checked);
                Config.SetShowSkin(chkShowSkin.Checked);
                Config.SetJavaMemory(numMemory.Value.ToString());

                MessageBox.Show("Les modifications ont été enregistrées !\nRedemarrez le launcher pour que la configuration prenne effet.");
            }

            this.Close();
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (bModifs)
            {
                MessageBox.Show("Les modifications n'ont pas été enregistrées !");
            }
            this.Close();
        }



        private void txtPath_TextChanged(object sender, EventArgs e)
        {
            bModifs = true;
        }

        private void txtJavaPath_TextChanged(object sender, EventArgs e)
        {
            bModifs = true;
        }

        private void chkAutoClose_CheckedChanged(object sender, EventArgs e)
        {
            bModifs = true;
        }

        private void optAdvancedMode_CheckedChanged(object sender, EventArgs e)
        {
            bModifs = true;
            if (optAdvancedMode.Checked)
            {
                optSimpleMode.Checked = false;
            }
        }

        private void optSimpleMode_CheckedChanged(object sender, EventArgs e)
        {
            bModifs = true;
            if (optSimpleMode.Checked)
            {
                optAdvancedMode.Checked = false;
            }
        }

        private void chkShowSkin_CheckedChanged(object sender, EventArgs e)
        {
            bModifs = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bModifs = true;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            bModifs = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void btnRefreshSkin_Click(object sender, EventArgs e)
        {
            Config.SetRefreshSkin(true);
            MessageBox.Show("Les skins seront rafaîchis au prochain démarrage du launcher.");
        }

    }
}
