using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;
using DTC.Common;

namespace DTC
{
    class Launcher
    {
        public static bool TestConfig()
        {
            if (!Config.Load())
            {
                MessageBox.Show("Impossible de lire ou écrire le fichier de configuration !", "Installation DTCLauncher", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }



        public static bool TestJavaBin()
        {
            string sJavaPath = Config.GetJavaPath();

            if (File.Exists(sJavaPath))
            {
                return true;
            }
            else
            {
                String sJavaLocatePath = "";
                String path = Environment.GetEnvironmentVariable("path");
                String[] folders = path.Split(';');
                foreach (String folder in folders)
                {
                    if (folder.ToLower().Contains("system32")) continue;

                    if (File.Exists(folder + "javaw.exe"))
                    {
                        sJavaLocatePath = folder;
                        Config.SetJavaPath(sJavaLocatePath + "javaw.exe");
                        return true;
                    }
                    else if (File.Exists(folder + "\\javaw.exe"))
                    {
                        sJavaLocatePath = folder + "\\";
                        Config.SetJavaPath(sJavaLocatePath + "javaw.exe");
                        return true;
                    }
                }
            }


            //Derniers trys !
            string sJavaPBinPath = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\java\\jre6\\bin\\javaw.exe";
            if (File.Exists(sJavaPBinPath))
            {
                Config.SetJavaPath(sJavaPBinPath);
                return true;
            }

            MessageBox.Show("Impossible de trouver JAVA, merci de saisir le chemin complet vers javaw.exe !", "Installation DTCLauncher", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            string sJavaUser = Microsoft.VisualBasic.Interaction.InputBox("Chemin vers javaw.exe", "Installation DTCLauncher", "");
            if (File.Exists(sJavaUser) && sJavaUser.Contains("javaw.exe"))
            {
                Config.SetJavaPath(sJavaUser);
                return true;
            }

            MessageBox.Show("Impossible de trouver JAVA !", "Installation DTCLauncher", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return false;
        }


        /*
        public static bool TestMcVersion()
        {
            string strTrueMcVersion = "";
            try
            {
                strTrueMcVersion = Minecraft.GetMinecraftVersion();
            }
            catch {
                MessageBox.Show("Minecraft n'est pas installé !\nInstallez minecraft de lancer DTCLauncher.", "DTCLauncher", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (strTrueMcVersion == Program.mcversion)
            {
                return true;
            }
            MessageBox.Show("Minecraft n'est pas à jour!\nInstallez minecraft et mettez le à jour avant d'installer DTCLauncher.", "DTCLauncher", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        */


        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            ClientPackages.Get();

            try
            {
                ServerPackages.Get();
            }
            catch (Exception E)
            {

            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmMain fMain = new frmMain();
            Application.Run(fMain);
        }

    }
}
