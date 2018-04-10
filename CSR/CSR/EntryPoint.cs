using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_06_04_2018
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            Car[] carArray = new Car[3]
       {
            new Car("Model1", "Compani1"),
            new Car("Model2", "Compani2"),
            new Car("Model1", "Compani3"),
       };

            Autohouse carList = new Autohouse(carArray);
            carList.couter = 1;
            foreach (Car p in carList)
            {
                Console.WriteLine(p.compani+ " "+ p.model);
            }
            carList.couter = 2;
            foreach (var p in carList)
            {
                Console.WriteLine(p);
            }
            carList.couter = 3;
            foreach (var p in carList)
            {
                Console.WriteLine(p);
            }
            carList.couter = 4;
            foreach (Car p in carList)
            {
                Console.WriteLine(p.compani + " " + p.model);
            }

        }
    }
}
