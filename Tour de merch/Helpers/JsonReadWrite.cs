using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace Tour_de_merch.Helpers
{
    public class JsonReadWrite
    {
        // format for use JsonRead<List<Value>(FileLocation)>
        public static TCollection JsonRead<TCollection>(string JsonFileName)
        {
            string json = File.ReadAllText(JsonFileName);
            return JsonConvert.DeserializeObject<TCollection>(json); 
        }
        // format for use JsonRead(Collection, FileLocation)
        public static void JsonWrite<TCollection>(TCollection Collection, string JsonFileName)
        {
            string json = JsonConvert.SerializeObject(Collection, Formatting.Indented);
            File.WriteAllText(JsonFileName, json);
        }

    }
}
