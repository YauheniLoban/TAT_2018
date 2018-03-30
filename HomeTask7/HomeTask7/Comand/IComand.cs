using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask7
{
     interface IComand
    {
        IEnumerable<Car> Execute(CarShowroom score, ProspectiveCar prorespectiveCar);
    }
}
