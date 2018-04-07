using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_06_04_2018
{
    class Autohouse : IEnumerable
    {
        private Car[] _car;
        public int couter { get; set; }

        public Autohouse(Car[] cars)
        {
            _car = new Car[cars.Length];
            for(int i=0;i<cars.Length;i++)
            {
                _car[i] = cars[i];
            }
        }

       public  IEnumerator GetEnumerator()
        {
            // return (IEnumerator)GetEnumerator();
            /*   if(couter==1)
                {
                    return new CarEnum(_car);
                }*/
            int cas=couter;
            switch ( cas )
                {
                case 1:
                    return new CarEnum(_car);
                case 2:
                    return new CompaneEnum(_car);
                case 3:
                    return new ModelEnum(_car);
                case 4:
                    return new UniqueModels(_car);
                default:
                    return new CarEnum(_car);
            }

        }

      /*  public CarEnum GetEnumerator()
        {
            return new CarEnum(_car);
        }*/
    }
}
