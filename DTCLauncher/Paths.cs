using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace DTC
{
    class Paths
    {
        public static string GetDtcRootPath()
        {
            return Path.GetFullPath("..\\..");
        }


        public static string GetSettingsPath()
        {
            return ".\\settings.xml";
        }
    }
}
