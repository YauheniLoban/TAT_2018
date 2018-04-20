using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_06_04_2018
{
    class Car
    {
        public string model { get; set; }
        public string compani { get; set; }

        public Car(string carModeel, string carCompani)
        {
            model = carModeel;
            compani = carCompani;
        }
    }
}
