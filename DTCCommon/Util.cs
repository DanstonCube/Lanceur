using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace DTC.Common
{

    public static class Util
    {
        public static bool CopyDir(string SourcePath, string DestPath)
        {
            try
            {
                DirectoryInfo SourceDir = new DirectoryInfo(SourcePath);
                DirectoryInfo DestDir = new DirectoryInfo(DestPath);

                if (!DestDir.Exists) DestDir.Create();

                foreach (FileInfo ChildFile in SourceDir.GetFiles())
                {
                    try
                    {
                        ChildFile.CopyTo(Path.Combine(DestDir.FullName, ChildFile.Name), true);
                    }
                    catch
                    {

                    }
                }

                foreach (DirectoryInfo SubDir in SourceDir.GetDirectories())
                {
                    if (!SubDir.Exists)
                    {
                        try
                        {
                            SubDir.Create();
                        }
                        catch { return false; }
                    }

                    if (!SubDir.Exists) return false;

                    try
                    {
                        bool retVal = CopyDir(SubDir.FullName, Path.Combine(DestDir.FullName, SubDir.Name));
                        if (!retVal) return false;
                    }
                    catch
                    {
                        return false;
                    }
                }

                return true;

            }
            catch (Exception ex)
            {
                //log any error...
                throw ex;
            }
        }

    }






    public static class MD5
    {
        public static string GetMD5HashFromFile(string fileName)
        {
            FileStream file = new FileStream(fileName, FileMode.Open);
            System.Security.Cryptography.MD5 md5 = new MD5CryptoServiceProvider();
            byte[] retVal = md5.ComputeHash(file);
            file.Close();

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < retVal.Length; i++)
            {
                sb.Append(retVal[i].ToString("x2"));
            }
            return sb.ToString();
        }
    }



    public static class Java
    {
        public static string LocateJava()
        {
            String javadir = "";
            String path = Environment.GetEnvironmentVariable("path");
            String[] folders = path.Split(';');
            foreach (String folder in folders)
            {
                if (folder.ToLower().Contains("system32")) continue;

                if (File.Exists(folder + "javaw.exe"))
                {
                    javadir = folder;
                    return javadir;
                }
                else if (File.Exists(folder + "\\javaw.exe"))
                {
                    javadir = folder + "\\";
                    return javadir;
                }
            }
            return "";
        }
    }
}
