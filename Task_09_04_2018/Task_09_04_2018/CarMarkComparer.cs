using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_09_04_2018
{
    class CarMarkComparer : IComparer<Car>
    {
        public int Compare(Car x, Car y)
        {
            if (x.mark == null && y.mark == null)
            {
                return 0;
            }
            else if (x.mark == null)
            {
                return -1;
            }
            else if (y.mark == null)
            {
                return 1;
            }
            else
            {
                return x.mark.CompareTo(y.mark);
            }
        }
    }
}
