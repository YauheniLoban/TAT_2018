using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_09_04_2018
{
    class Car
    {
        public string mark { get; set; }
        public string model { get; set; }
        public float volum { get; set; }

        public Car(string carModeel, string carMark, float carVolum)
        {
            model = carModeel;
            mark = carMark;
            volum = carVolum;
        }

        public void OutPutInform()
        {
            Console.WriteLine(this.model + "  " + this.mark + "  " + this.volum);
        }
    }
}
