using System;

namespace DevTask2
{
    /// <summary> 
    /// EntryPoint
    /// Gets the string from console and prints a substring of elements with even indices to the console
    /// </summary> 
    class EntryPoint
    {
        static void Main(string[] args)
        {
            string inputString;
            do
            {
                Console.WriteLine("Enter a non-empty string");
                inputString = Console.ReadLine();
            } while (inputString.Length == 0);

            SubstringOfEvenElements EvenIndexString = new SubstringOfEvenElements();
            Console.WriteLine(EvenIndexString.CreateSubstringOfEvenElements(inputString));
        }
    }
}
