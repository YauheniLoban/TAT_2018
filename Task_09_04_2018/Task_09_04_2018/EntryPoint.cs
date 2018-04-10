using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_09_04_2018
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            List<Car> carArray = new List<Car>
        {
            new Car("Ford", "Compani1",10),
            new Car("Gele", "Compani2",11),
            new Car("M3", "AAAAA",12),
            new Car("Mood", "Compani4",13),
            new Car("Model4", "BBBBBB",14),
            new Car("Model6", "Compani6",2),
            new Car("Model82", "Compani7",16),
            new Car("Model8", "Compani8",17),
            new Car("aaaaaa", "Compani9",18),
            new Car("bbbbb", "Compani10",19),
            new Car("Model11", "Compani11",20),
            new Car("Model12", "Compani12",21),
            new Car("Model13", "Compani13",22),
            new Car("Model14", "Compani14",23),
            new Car("Model15", "Compani15",5),
       };
            AvtoHous avtoHouse = new AvtoHous(carArray);
            Comparison<Car> delegat = Helper.ModelSort;
            Console.WriteLine("\nBefor:");
            avtoHouse.InformationOutput();

            avtoHouse._car.Sort(delegat);
            Console.WriteLine("\n After:");
            avtoHouse.InformationOutput();

            delegat = Helper.MarkSort;
            avtoHouse._car.Sort(delegat);
            Console.WriteLine("\n After:");
            avtoHouse.InformationOutput();

            delegat = Helper.VolumSort;
            avtoHouse._car.Sort(delegat);
            Console.WriteLine("\n After:");
            avtoHouse.InformationOutput();

            delegat = Helper.LengthMarkSort;
            avtoHouse._car.Sort(delegat);
            Console.WriteLine("\n After: ");
            avtoHouse.InformationOutput();

            CarModelComparer modelComparer = new CarModelComparer();
            avtoHouse._car.Sort(modelComparer);
            Console.WriteLine("\n After: Comparer 1");
            avtoHouse.InformationOutput();

            CarMarkComparer markComparer = new CarMarkComparer();
            avtoHouse._car.Sort(markComparer);
            Console.WriteLine("\n After: Comparer 2");
            avtoHouse.InformationOutput();

            CarVolumComparer volumComparer = new CarVolumComparer();
            avtoHouse._car.Sort(volumComparer);
            Console.WriteLine("\n After: Comparer 3");
            avtoHouse.InformationOutput();
        }
    }
}
