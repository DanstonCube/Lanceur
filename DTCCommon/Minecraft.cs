using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace DTC.Common
{
    public class Minecraft
    {
        //
        public static string GetMinecraftPath()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.minecraft";
        }

        //
        public static string GetMinecraftVersionFile()
        {
            return GetMinecraftPath() + "\\bin\\version";
        }


        public static string GetMinecraftVersionFile(string minecraftfolder)
        {
            string subdir = "";


            if (Path.GetDirectoryName(minecraftfolder) != ".minecraft")
            {
                if (Directory.Exists(minecraftfolder + "\\.minecraft"))
                {
                    subdir = "\\.minecraft";
                }
                else
                {
                    throw new Exception("Impossible de trouver une installation de minecraft dans " + minecraftfolder);
                }
            }
            else
            {
            }

            return minecraftfolder + subdir + "\\bin\\version";
        }



        //
        public static string GetMinecraftVersion()
        {
            return File.ReadAllText(GetMinecraftVersionFile()).Replace("\0\r","");
        }




        public static string GetMinecraftVersion(string minecraftfolder)
        {
            string strVersion = "";
            string sVersionFile = GetMinecraftVersionFile(minecraftfolder);
            if (File.Exists(sVersionFile))
            {
                strVersion = File.ReadAllText(sVersionFile).Replace("\0\r", "");                
            }
            return strVersion;
        }


        public static void SetMinecraftVersion(string minecraftfolder, string version)
        {
            string sVersionFile = GetMinecraftVersionFile(minecraftfolder);
            if (File.Exists(sVersionFile))
            {
                File.WriteAllText(sVersionFile, "\0\r" + version);
            }
        }





        /*
         * if (strVersion != Program.mcversion)
                {
                    File.WriteAllText(sVersionFile, "\0\r" + Program.mcversion);
                }
         * */

        public static bool IsValidMinecraftInstall(string foldertotest)
        {
            if (Path.GetDirectoryName(foldertotest) != ".minecraft")
            {
                if (!Directory.Exists(Path.GetFullPath(foldertotest) + "\\.minecraft"))
                {
                    return false;
                }
            }


            //ici = dossier minecraft ok, test des fichiers

            //version=?
            //jar=?
            //libs=?



            return true;
        }




    }
}
