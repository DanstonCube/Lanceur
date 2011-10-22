using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;

namespace DTC
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //todo
            Process p = new Process();
            p.StartInfo.FileName = ".\\DTCUpdater.exe";
            p.StartInfo.Arguments = "skipmain";
            p.Start();
        }
    }
}
