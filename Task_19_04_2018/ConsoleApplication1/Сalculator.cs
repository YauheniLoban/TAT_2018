using System;
using System.Collections.Generic;

namespace Task_19_04_2018
{
    /// <summary>  
    /// class containing various ways of calculating the distance between two points
    /// </summary> 
    class Сalculator
    {
        /// <summary>  
        /// Calculate Distance in rectangular coordinates
        /// </summary> 
        public double DistanceInRectangularCoordinates(List<double> x, List<double> y)
        {
            double distance = 0;
            if(x.Count==y.Count)
            {
                for(int i=0;i<x.Count;i++)
                {
                    distance += Math.Pow(x[i] - y[i],2);
                }
                distance = Math.Sqrt(distance);
            }
            else
            {
                throw new ArgumentException();
            }
            return distance;
        }

        /// <summary>  
        /// Calculate Distance in some coordinates
        /// </summary> 
        public double DistanceInSomeCoordinates(List<double> x, List<double> y)
        {
            double distance = 0;
            if (x.Count == y.Count)
            {
                for (int i = 0; i < x.Count; i++)
                {
                    distance += Math.Pow(x[i] + y[i], 2);
                }
                distance = Math.Sqrt(distance);
            }
            else
            {
                throw new ArgumentException();
            }
            return distance;
        }

    }
}
