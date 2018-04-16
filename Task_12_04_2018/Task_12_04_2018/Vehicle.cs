using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12_04_2018
{
    struct Vehicle
    {
        public Driver driver { get; set; }
        public Car car { get; set; }
        
        public Vehicle(Car _car,Driver _driver)
        {
            car = _car;
            driver = _driver;
        } 

        public void OutputInformation()
        {
            car.OutputInformation();
            driver.OutputInformation();
        }
    }
}
