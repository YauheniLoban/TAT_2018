using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12_04_2018
{
    struct Car
    {
        public string model { get; set; }
        public string mark { get; set; }

        public Car(string _model, string _mark)
        {
            mark = _mark;
            model = _model;
        }

        public void OutputInformation()
        {
            Console.WriteLine("model : " + model + "  mark : " + mark);
        }
    }
}
