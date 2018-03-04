using System;
using System.Text;

namespace DevTask2
{
    /// <summary> 
    /// SubstringOfCharactersWithEvenIndices
    /// Prints a substring of elements with even indices to the console
    /// </summary> 
    class SubstringOfCharactersWithEvenIndices
    {
        static void Main(string[] args)
        {
            string stringEnteredFromConsole;
            do
            {
                Console.WriteLine("Enter a non-empty string");
                stringEnteredFromConsole = Console.ReadLine();
            }
            while (stringEnteredFromConsole.Length == 0);
            
            SubstringOfCharactersWithEvenIndices EntryPointObject = new SubstringOfCharactersWithEvenIndices();         
            Console.WriteLine(EntryPointObject.CreateSubstringOfEvenElements(stringEnteredFromConsole));
        }


        /// <summary> 
        /// Method CreateSubstringOfEvenElements
        /// Function to create a string consisting of even elements of the transmitted string
        /// </summary> 
        /// <param name="stringForSelectingSubstring">String, which was inputed</param> 
        /// <returns>Created substring</returns>
        string CreateSubstringOfEvenElements(string stringForSelectingSubstring)
        {
            string returnSubstring;
            StringBuilder allocatedSubstring = new StringBuilder();

            for (int i = 0; i < stringForSelectingSubstring.Length; i += 2)
            {
                allocatedSubstring.Append(stringForSelectingSubstring[i]); // Add an element to the selected row
            }

            returnSubstring = allocatedSubstring.ToString();
            return returnSubstring;
        }
    }
}
