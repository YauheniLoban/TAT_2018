using System.Collections.Generic;

namespace Task_19_04_2018
{
    /// <summary>  
    /// Two points in some coordinate system and 
    /// </summary> 
    class Сoordinates
    {
        public List<double> point1 = new List<double>();
        public List<double> point2 = new List<double>();
        public MethodOfCalculation counter { get; set; }

        public Сoordinates(List<double> x, List<double> y, MethodOfCalculation _counter)
        {
            point1 = x;
            point2 = y;
            counter = _counter;
        }

        /// <summary>  
        /// Calculate the distance between two points
        /// </summary> 
        public double GetDistens()
         {
            return counter(point1, point2);
         }
    }
}
