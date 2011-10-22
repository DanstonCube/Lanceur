using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using DTC.Common;

namespace DTC
{
    public partial class frmDebug : Form
    {
        public frmDebug()
        {
            InitializeComponent();
        }

        private void frmDebug_Load(object sender, EventArgs e)
        {
            string strInstallPath = Config.GetPath();
            string strAppDataPath =  Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

            //
            try
            {
                txtJarMD5.Text = MD5.GetMD5HashFromFile("..\\..\\install\\DTC\\patch\\bin\\minecraft.jar");
#if DEBUG
                txtJarMD5.Text = MD5.GetMD5HashFromFile("..\\..\\installdev\\DTC\\patch\\bin\\minecraft.jar");
#endif
            }
            catch { }


            txtInstalledMcVersion.Text = File.ReadAllText(strAppDataPath + "\\.minecraft\\bin\\version").Replace("\0\r", "");
            //txtJarVersion.Text = Program.jarversion;
            txtMcVersion.Text = Program.mcversion;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo("notepad.exe", Paths.GetSettingsPath());
            System.Diagnostics.Process.Start(startInfo);
            startInfo = null;
        }

        private void btnResetSettings_Click(object sender, EventArgs e)
        {
            File.Delete(Paths.GetSettingsPath());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sAppDataPath = DTC.Common.Paths.GetRootDTC() + "\\Packages\\dtc_166";
            Program.MakeBatchFile(".\\run.bat",sAppDataPath);
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo(".\\run.bat");
            startInfo.Arguments = "mikob3d cenestpasmonmotdepasse danstoncube.tupeuxpastest.com";
            System.Diagnostics.Process.Start(startInfo);
            startInfo = null;
        }
    }
}
