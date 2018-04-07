using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_06_04_2018
{
    class UniqueModels : IEnumerator
    {
        Car[] _car ;
       
        int position = -1;
        public UniqueModels(Car[] list)
        {
                bool coun = true;
                List<Car> uniq = new List<Car>();
                for(int i =0;i<list.Length;i++)
                {
                  for(int j =0;j<i;j++)
                    {
                        if(list[i].model==list[j].model)
                        {
                            coun = false;
                            break;
                        }
                    }
                    if(coun)
                    {
                        uniq.Add(list[i]);
                    }
                    coun = true;
                }

              _car = uniq.ToArray();
        }
        public bool MoveNext()
        {
       
            position++;
            return (position < _car.Length);
        }

        public void Reset()
        {
            position = -1;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public Car Current
        {
            get
            {
                try
                {
                    return _car[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }

        }
    }
}