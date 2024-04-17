using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR5.Model
{
    internal class Jsonka
    {
        public static void Ser<T>(string path, T obj) => File.WriteAllText(path, JsonConvert.SerializeObject(obj));
        public static T Des<T>(string path)
        {
            if (!File.Exists(path))
                File.WriteAllText(path, "");
            return JsonConvert.DeserializeObject<T>(File.ReadAllText(path));
        }
    }
}
