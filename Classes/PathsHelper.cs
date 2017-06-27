using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eViewer.Classes
{
    public static class PathsHelper
    {
        public static string LayoutPath
        {
            get 
            {
                if (Directory.Exists(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + @"\Layout\") == false)
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + @"\Layout\");
                }
                return Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + @"\Layout\"; 
            }
        }
    }
}
