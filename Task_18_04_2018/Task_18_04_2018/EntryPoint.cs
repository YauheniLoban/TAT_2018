using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Enter 2 number: ");
            int number1= Int32.Parse(Console.ReadLine());
            int number2 = Int32.Parse(Console.ReadLine());
            Example(number1,number2);
        }
    }

    static async void Example(int number1,int number2)
    {
        double t = await Task.Run(() => Allocate(number1,number2));
        Console.WriteLine("Compute: " + t);
    }

    static double Allocate(int number1, int number2)
    {
        double size = 0; 
        size += Math.Pow(number2, number1);
        Thread.Sleep(10000);     
        return size;
    }
}
