using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grid
{
    static class DataTranformer
    {
        public static List<Teacher> teacherList = new List<Teacher>();
        public static string dir = PathToFiles();
        public static string exeptionDir = PathToFiles() + "404.jpg";
        private static string PathToFiles() 
        {
            string path = Environment.CurrentDirectory;
            string path2 = path.Substring(0, path.LastIndexOf("bin")) + "Images" + "\\";
            return path2;
        }
    }
}
