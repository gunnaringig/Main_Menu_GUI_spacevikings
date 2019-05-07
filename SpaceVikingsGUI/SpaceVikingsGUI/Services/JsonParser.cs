using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Collections.ObjectModel;

namespace SpaceVikingsGUI.Services
{
    public class JsonParser
    {
        public static void Save<T>(string path, List<T> obj)
        {
            string json = JsonConvert.SerializeObject(obj);
            WriteToFile(path, json);
        }

        public static List<T> Load<T>(string path)
        {
            string json = ReadFromFile(path);
            if (json != null)
            {
                return JsonConvert.DeserializeObject<List<T>>(json);
            }
            return null;
        }

        private static string ReadFromFile(string path)
        {
            if (File.Exists(path))
            {
                return File.ReadAllText(path);
            }
            return null;
        }

        private static void WriteToFile(string path, string data)
        {
            File.WriteAllText(path, data);
        }
    }
}
