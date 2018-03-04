using System;

namespace DevTask2
{
    /// <summary> 
    /// EntryPointObject
    /// Gets the string from console and prints a substring of elements with even indices to the console
    /// </summary> 
    class EntryPoint
    {
        static void Main(string[] args)
        {
            string stringEnteredFromConsole;
            do
            {
                Console.WriteLine("Enter a non-empty string");
                stringEnteredFromConsole = Console.ReadLine();
            } while (stringEnteredFromConsole.Length == 0);

            SubstringOfCharactersWithEvenIndices EvenIndexString = new SubstringOfCharactersWithEvenIndices();
            Console.WriteLine(EvenIndexString.CreateSubstringOfEvenElements(stringEnteredFromConsole));
        }
    }
}
