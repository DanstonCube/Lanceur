using System;
using System.IO;


namespace DTC.Common
{
    public class Paths
    {

        //
        public static string GetRootDTC()
        {
            #if DEBUG
                return "D:\\DOCZ\\My Dropbox\\DEV\\DansTonCube\\INSTALLDEV";
            #endif

            if (Path.GetFullPath(".").EndsWith("launcher"))
            {
                return Path.GetFullPath("..\\..");
            }
            else if (Path.GetFullPath(".").EndsWith("Release"))
            {
                return "D:\\DOCZ\\My Dropbox\\DEV\\DansTonCube\\INSTALLDEV";
            }


            /*
            if (File.Exists(".\\DTCUpdater.exe"))
            {

            }
            */

            return Path.GetFullPath(".");
        }

        //
        public static string GetTempPath()
        {
            return Path.GetFullPath(GetRootDTC() + "\\Temp");
        }


        //
        public static string GetLocalPackagesXmlFile()
        {
            return Path.GetFullPath(Paths.GetLocalPackagesDir() + "\\packages.xml");
        }

        //
        public static string GetLocalPackagesXmlFile(string sPackagesXmlFile)
        {
            return Path.GetFullPath(Paths.GetLocalPackagesDir() + "\\" + sPackagesXmlFile);
        }

        //
        public static string GetLocalPackagesDir()
        {
            return Path.GetFullPath(Paths.GetRootDTC() + "\\Packages");
        }

        //
        public static string GetLocalPackagesDir(string sPackagesDir)
        {
            return Path.GetFullPath(Paths.GetRootDTC() + "\\" + sPackagesDir);
        }

        //
        public static string GetLocalTempDir()
        {
            return Path.GetFullPath(Paths.GetRootDTC() + "\\Temp");
        }
        
        //
        public static string ComputePath(string PathExpression, string variable="")
        {
            PathExpression = PathExpression.Replace("%PACKAGESDIR%", Paths.GetLocalPackagesDir(""));
            PathExpression = PathExpression.Replace("%PACKAGE%", Paths.GetLocalPackagesDir() + "\\" + variable);
            PathExpression = PathExpression.Replace("%LAUNCHER%", Path.GetFullPath("."));
            return PathExpression;
        }

    }
}
