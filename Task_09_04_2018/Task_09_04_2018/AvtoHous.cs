using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_09_04_2018
{
    class AvtoHous
    {
        public List<Car> _car = new List<Car>();

        public AvtoHous(List<Car> cars)
        {
            _car = cars;
        }

        public void InformationOutput()
        {
            foreach(Car nextCar in this._car)
            {
                nextCar.OutPutInform();
            }
        }
    }
}
