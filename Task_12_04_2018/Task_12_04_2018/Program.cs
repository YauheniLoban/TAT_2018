using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12_04_2018
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> str = new List<Vehicle>()
            {
               new Vehicle(new Car("M2","BMV"),new Driver("Zhenya","Loban",29,25553)),
               new Vehicle(new Car("M518","BMV"),new Driver("Zhenya","Loban",29,25554)),
               new Vehicle(new Car("M2","Audi"),new Driver("Andr","Loban",29,25558)),
               new Vehicle(new Car("M2","BMV"),new Driver("Alex","Kors",29,25558)),
               new Vehicle(new Car("M2", "BMV"), new Driver("And", "Korol", 29, 25550))
            };

            Vehicles vehicles = new Vehicles(str);
            Console.WriteLine("1st Consition");
            vehicles.OutputInformationSuitableUnder1Condition();
            Console.WriteLine("2st Consition");
            vehicles.OutputInformationSuitableUnder2Condition();
        }
    }
}
