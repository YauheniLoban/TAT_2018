using System;

namespace Test_Progect2
{
    /// <summary>
    /// We get from the command line the length and width of the rectangle, calculate its square
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                if(args.Length<2)
                {
                    throw new ArgumentException("Insufficient number of parameters");
                }
                double width;
                double length;
                if( !Double.TryParse(args[0],out width) || !Double.TryParse(args[1],out length))
                {
                  throw new ArgumentException("Width and length are incorrect");
                }
                Rectangle rectangle = new Rectangle(width, length);
                Console.WriteLine(rectangle.CalculateSquare());
            }
            catch(ArgumentException exeption)
            {
                Console.WriteLine(exeption.Message);
            }
        }
    }
}
