﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_06_04_2018
{
    class ModelEnum : IEnumerator
    {
        Car[] _car;
        int position = -1;
        public ModelEnum(Car[] list)
        {
            _car = list;
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

        public string Current
        {
            get
            {
                try
                {
                      return _car[position].model;
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }

        }
    }
}