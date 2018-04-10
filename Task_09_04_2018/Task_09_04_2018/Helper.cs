using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_09_04_2018
{
    class Helper
    {
        public static int ModelSort(Car x, Car y)
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
        public static int MarkSort(Car x, Car y)
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
        public static int LengthMarkSort(Car x, Car y)
        {
            if (x.mark.Length == 0 && y.mark.Length == 0)
            {
                return 0;
            }
            else if (x.mark.Length == 0)
            {
                return -1;
            }
            else if (y.mark.Length == 0)
            {
                return 1;
            }
            else
            {
                return x.mark.Length.CompareTo(y.mark.Length);
            }
        }
        public static int VolumSort(Car x, Car y)
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
