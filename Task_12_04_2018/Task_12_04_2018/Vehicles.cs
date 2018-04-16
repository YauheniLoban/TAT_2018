using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12_04_2018
{
    class Vehicles
    {
       public List<Vehicle> vehicles;

       public Vehicles(List<Vehicle> _vehicles)
        {
            vehicles = _vehicles;
        }
        
       public void OutputInformationSuitableUnder1Condition()
        {
            var selectedVehicles = from nextVehicles in vehicles
                                  where (nextVehicles.driver.age > 25)
                                  where (nextVehicles.car.mark == "BMV")
                                  where (nextVehicles.driver.cardNumber % 10 < 5)
                                  select nextVehicles;
            foreach(Vehicle nextVehicle in selectedVehicles)
            {
                nextVehicle.OutputInformation();
            }
        }
        public void OutputInformationSuitableUnder2Condition()
        {
            var selectedVehicles = from nextVehicles in vehicles
                                   where (nextVehicles.driver.firstName.Length < 5)
                                   where (nextVehicles.car.mark != "Audi") 
                                   select nextVehicles;
            foreach (Vehicle nextVehicle in selectedVehicles)
            {
                nextVehicle.OutputInformation();
            }
        }
    }
}
