using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace grid
{
    static class DataTranformer
    {
        
        public static List<Teacher> teacherList = new List<Teacher>();
        public static string dir = PathToFiles();
        public static string exeptionDir = PathToFiles() + "404.jpg";
        public static string saveDir = PathToFiles() + "Teachers.json";
        public static string name;

        public static string PathToFiles()
        {
            string path = Environment.CurrentDirectory;
            string path2 = path.Substring(0, path.LastIndexOf("bin")) + "Data" + "\\";
            return path2;
        }

        public static void Load() 
        {
            teacherList = JsonConvert.DeserializeObject<List<Teacher>>(File.ReadAllText(saveDir));
        }
    }
}
