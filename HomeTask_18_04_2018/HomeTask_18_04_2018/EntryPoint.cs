using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HomeTask_18_04_2018
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            List<FileInformation> str = new List<FileInformation>();
            JsonReader reader = new JsonReader();
            str = reader.ReadJsonFile("C:\\Users\\Lenovo\\Source\\Repos\\NewRepo\\HomeTask_18_04_2018\\HomeTask_18_04_2018\\URLAndFileName.json");
            Downloder downloder = new Downloder(str);
            downloder.DownloadAllFile();
            Console.WriteLine("something");
            Console.ReadLine();
        }
    }
}
