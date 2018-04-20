using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_09_04_2018
{
    class CarVolumComparer : IComparer<Car>
    {
        public int Compare(Car x, Car y)
        {
            if (x.volum == 0 && y.volum == 0)
            {
                return 0;
            }
            else if (x.volum == 0)
            {
                return -1;
            }
            else if (y.volum == 0)
            {
                return 1;
            }
            else
            {
                return x.volum.CompareTo(y.volum);
            }
        }
    }
}
