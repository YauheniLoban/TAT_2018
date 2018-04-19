using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_18_04_2018
{
    class FileInformation
    {
       public string url { get; set; }
       public string fileName;

        public FileInformation(string URL, string FileName)
        {
            url = URL;
            fileName = FileName;
        }

        public override string ToString()
        {
            return url + "   " + fileName;
        }
    }
}
