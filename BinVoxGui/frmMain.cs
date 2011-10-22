using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace BinVoxGui
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnSchematicBrowse_Click(object sender, EventArgs e)
        {
            Program.OpenExplorer(".\\Schematics\\");
        }

        private void btnObjBrowse_Click(object sender, EventArgs e)
        {
            Program.OpenExplorer(".\\Obj\\");
        }

        private void btnBinvoxBrowse_Click(object sender, EventArgs e)
        {
            Program.OpenExplorer(Path.GetFullPath(".\\Binvox\\"));
        }

        private void btnCmdPrompt_Click(object sender, EventArgs e)
        {
            Program.OpenCommandLine(".\\");
        }


        private void tabMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabMenu.SelectedTab.Name == "tabConvert")
            {
                btnLaunchBinvox.Visible = true;
                btnLaunchViewvox.Visible = false;
            }
            else
            {
                btnLaunchBinvox.Visible = false;
                btnLaunchViewvox.Visible = true;
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            foreach (string file in Directory.GetFiles(".\\Binvox", "*.binvox"))
            {
                cboBinvox.Items.Add(Path.GetFileNameWithoutExtension(file));
            }

            foreach (string file in Directory.GetFiles(".\\Obj", "*.obj"))
            {
                cboObj.Items.Add(Path.GetFileNameWithoutExtension(file));
            }


        }

        private void btnBrowseBinvox_Click(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = Path.GetFullPath(".\\Binvox");
            openFileDialog.Title = "Fichier .binvox à visualiser";
            openFileDialog.Filter = "Fichiers binvox|*.binvox";
            DialogResult dlgResult = openFileDialog.ShowDialog();
            if (dlgResult != System.Windows.Forms.DialogResult.Cancel)
            {
                cboBinvox.Text = openFileDialog.FileName;
            }
        }

        private void btnBrowseObj_Click(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = Path.GetFullPath(".\\Obj");
            openFileDialog.Title = "Fichier .obj à convertir";
            openFileDialog.Filter = "Fichiers obj|*.obj";
            DialogResult dlgResult = openFileDialog.ShowDialog();
            if (dlgResult != System.Windows.Forms.DialogResult.Cancel)
            {
                cboObj.Text = openFileDialog.FileName;
            }
        }

        private void btnLaunchViewvox_Click(object sender, EventArgs e)
        {
            if (cboBinvox.Text == "")
            {
                MessageBox.Show("Veuillez choisir un fichier à visualiser !");
                return;
            }

            string binvoxfile = Path.GetFullPath(cboBinvox.Text);
            if (!File.Exists(binvoxfile))
            {
                binvoxfile = Path.GetFullPath(".\\Binvox\\" + cboBinvox.Text + ".binvox");
                if(!File.Exists(binvoxfile))
                {
                    MessageBox.Show("Impossible de trouver le fichier à visualiser !");
                    return;
                }
            }

            Process p = new Process();
            p.StartInfo.FileName = Path.GetFullPath(".\\viewvox.exe");
            p.StartInfo.Arguments = "\"" + binvoxfile + "\"";
            p.Start();
            p.Dispose();
        }

        private void btnLaunchBinvox_Click(object sender, EventArgs e)
        {
           
            string cmd = "";

            if (cboObj.Text.Trim() == "")
            {
                MessageBox.Show("Veuillez choisir un fichier à convertir !");
                return;
            }

            string objfile = Path.GetFullPath(cboObj.Text);
            if (!File.Exists(objfile))
            {
                objfile = Path.GetFullPath(".\\Obj\\" + cboObj.Text + ".obj");
                if (!File.Exists(objfile))
                {
                    MessageBox.Show("Impossible de trouver le fichier à convertir !");
                    return;
                }
            }



            //todo: generer cmd

            cmd = MakeBinvoxCommand(objfile);


            Process p = new Process();
            p.StartInfo.FileName = Path.GetFullPath(".\\binvox.exe");
            p.StartInfo.Arguments = cmd;
            p.Start();
            p.Dispose();
        }

        public string MakeBinvoxCommand(string objfile)
        {
            string command = "";



            //Taille box
            string cmd_taille = "";
            if (optD.Checked)
            {
                cmd_taille = "-d " + numericD.Value.ToString();
            }
            else
            {
                if (optDown8.Checked)       cmd_taille = "-down -down -down -down -down";
                if (optDown16.Checked)      cmd_taille = "-down -down -down -down";
                if (optDown32.Checked)      cmd_taille = "-down -down -down";
                if (optDown64.Checked)      cmd_taille = "-down -down";
                if (optDown128.Checked)     cmd_taille = "-down";
                if (optDown256.Checked)     cmd_taille = "";
            }
            
            //Format
            string cmd_format = "";
            if (optTypeSchematic.Checked)
            {
                cmd_format = "-t schematic";
            }

            //Ri
            string cmd_ri = "";
            if (chkRi.Checked)
            {
                cmd_ri = "-ri";
            }

            //Cb
            string cmd_cb = "";
            if (chkCb.Checked)
            {
                cmd_ri = "-cb";
            }

            //Bi
            string cmd_bi = "";
            if (chkBi.Checked && optTypeSchematic.Checked)
            {
                cmd_bi = "-bi " + numericBi.Value.ToString();
            }

            //custom
            string cmd_custom = "";
            if (txtCustomParams.Text.Trim() != "")
            {
                cmd_custom = txtCustomParams.Text.Trim();
            }

            if (cmd_format != "")   command += ((command != "") ? " " : "") + cmd_format;
            if (cmd_taille != "")   command += ((command != "") ? " " : "") + cmd_taille;
            if (cmd_cb != "")       command += ((command != "") ? " " : "") + cmd_cb;
            if (cmd_ri != "")       command += ((command != "") ? " " : "") + cmd_ri;
            if (cmd_bi != "")       command += ((command != "") ? " " : "") + cmd_bi;
            if (cmd_custom != "")   command += ((command != "") ? " " : "") + cmd_custom;
            if (objfile != "")      command += ((command != "") ? " " : "") + "\"" + objfile + "\"";


            return command;
        }

        private void txtCustomParams_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
