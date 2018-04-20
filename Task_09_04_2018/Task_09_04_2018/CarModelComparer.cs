using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_09_04_2018
{
    class CarModelComparer : IComparer<Car>
    {
        public int Compare(Car x, Car y)
        {
            if (x.model == null && y.model == null)
            {
                return 0;
            }
            else if (x.model == null)
            {
                return -1;
            }
            else if (y.model == null)
            {
                return 1;
            }
            else
            {
                return x.model.CompareTo(y.model);
            }
        }
    }
}
