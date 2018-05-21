using System;

namespace Test_Progect2
{
    /// <summary>
    /// Class storing information about the rectangle and method for calculating the area
    /// </summary>
    public class Rectangle
    {
        double width { get; set; }
        double length { get; set; }

        /// <summary>
        /// Constructor with built-in validation of the value of length and width
        /// </summary>
        /// <param name="width">rectangle width</param>
        /// <param name="length">rectangle length</param>
        public Rectangle(double width, double length)
        {
            if (width<=0||length<=0)
            {
                throw new ArgumentException("Length and width can not have zero or negative lengths");
            }
            else
            {
                this.width = width;
                this.length = length;
            }
        }

        /// <summary>
        /// Calculate the area of the triangle S=width * length
        /// </summary>
        public double CalculateSquare()
        {
            return width * length;
        }
    }
}
