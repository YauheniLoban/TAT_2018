using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HomeTask_18_04_2018
{
    class JsonReader
    {
        public List<FileInformation> ReadJsonFile(string wayToFile)
        {
           return JsonConvert.DeserializeObject<List<FileInformation>>(File.ReadAllText(wayToFile));
        }
    }   
}
