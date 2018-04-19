using System;
using System.Collections.Generic;

namespace Task_19_04_2018
{
    public delegate double MethodOfCalculation(List<double> x, List<double> y);

    /// <summary>  
    /// using various functions to calculate distance, advanced functions through delegates
    /// </summary> 
    class EntryPoint
    {
        static void Main(string[] args)
        {
            List<double> x = new List<double> { 0,0};
            List<double> y = new List<double> { 3,4 };
            Сalculator comands = new Сalculator();
            Сoordinates pairOfCoordinates = new Сoordinates(x, y, comands.DistanceInRectangularCoordinates);
            Console.WriteLine("Resalt:" + pairOfCoordinates.GetDistens());
            x.Add(0);
            y.Add(10);
            pairOfCoordinates.point1 = x;
            pairOfCoordinates.point2 = y;
            Console.WriteLine("Resalt:" + pairOfCoordinates.GetDistens());
            pairOfCoordinates.counter = comands.DistanceInSomeCoordinates;
            Console.WriteLine("Resalt:" + pairOfCoordinates.GetDistens());
        }
    }
}
