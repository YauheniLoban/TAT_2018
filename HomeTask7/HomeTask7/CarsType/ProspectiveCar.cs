using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask7
{
   public class ProspectiveCar : Car
    {
        public string mark { get; set; }

        public void EnteringTheDesiredCharacteristics()
        {
            Console.WriteLine("If any options you are not interested in, enter an empty string");
            Console.WriteLine("Enter the car make ");
            this.mark = Console.ReadLine();
            Console.WriteLine("Enter the car model");
            this.model = Console.ReadLine();
            Console.WriteLine("Enter the body type of the car");
            this.typeOfBody = Console.ReadLine();
            Console.WriteLine("Enter the transmission type");
            this.transmissionType = Console.ReadLine();
            Console.WriteLine("Enter the type of engine");
            this.engineType = Console.ReadLine();
            Console.WriteLine("Enter the volume");
            this.volume = Console.ReadLine();
            Console.WriteLine("Enter the power");
            this.power = Console.ReadLine();
            Console.WriteLine("Enter a way to manage the climate");
            this.climateControl = Console.ReadLine();
            Console.WriteLine("Enter the type of salon");
            this.salonType = Console.ReadLine();

        }
    }
}
