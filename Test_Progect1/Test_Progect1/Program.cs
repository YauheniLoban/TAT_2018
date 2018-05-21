using System;

namespace Test_Task1
{
    /// <summary>
    /// Output 3 lines. The number of exclamation marks in the 3rd line is generated randomly from 5 to 50
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, world! " + "\nAnd hi again! ");
            Random rnd = new Random();
            int numberExclamationPoints = rnd.Next(5, 50);
            for (int i = 0; i < numberExclamationPoints; i++)
            {
                Console.Write("!");
            }
        }
    }
}
