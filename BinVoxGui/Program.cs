using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace BinVoxGui
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                CheckFolders();
            }
            catch
            {
                MessageBox.Show("Impossible d'écrire dans le dossier. Droits incorrects ? Fermeture !");
                Application.Exit();
            }

            try
            {
                CheckFiles();
            }
            catch
            {
                MessageBox.Show("Un ou plusieurs fichier(s) manquant(s). Fermeture !");
                Application.Exit();
            }


          

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }


        public static void CheckFiles()
        {
            CheckFile("binvox.exe");
            CheckFile("viewvox.exe");
            CheckFile("glut32.dll");
        }

        public static void CheckFile(string file)
        {
            if (!File.Exists(file))
            {
                throw new Exception("Fichier requis manquant: " + file);
            }
        }


        public static void CheckFolders()
        {
            CheckFolder(".\\Binvox");
            CheckFolder(".\\Obj");
            CheckFolder(".\\Schematics");
        }

        public static void CheckFolder(string folder)
        {
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }
        }

        public static void OpenExplorer(string path)
        {
            Process p = new Process();
            p.StartInfo.UseShellExecute = true;
            p.StartInfo.FileName = path;
            p.Start();
            p.Dispose();
        }

        public static void OpenCommandLine(string path)
        {
            Process p = new Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.FileName = "cmd";
            p.Start();
            p.Dispose();
        }



    }
}
