using DevTask3;
using System;

namespace Task_Dev3
{
    /// <summary> 
    /// EntryPoint
    /// We accept from the command line two arguments: 
    /// 1) the number that needs to be transferred to another system of calculation 
    /// 2) the foundation of a new system of calculus 
    /// </summary> 
    class EntryPoint
    {
        static void Main(string[] args)
        {
            // We check the arguments for the correctness of the input (only numbers can be entered)
            if(args[0] == string.Empty || args[1] == string.Empty)
            {
                Console.WriteLine("You entered an empty string");
                return;
            }
            long numberForCheck;
            if (!Int64.TryParse(args[0], out numberForCheck) || !Int64.TryParse(args[1], out numberForCheck))
            {
                Console.WriteLine("You entered not only numbers in the argument string. Please correct the arguments");
                return;
            }
            if (Convert.ToInt16(args[1]) < 2 || Convert.ToInt16(args[1]) > 20)
            {
                Console.WriteLine("You entered the base of the new system not from the allowed range. Please enter another base of the new system ");
                return;
            }
            TranslationIntoNewSystem convertedString = new TranslationIntoNewSystem(args);       
            Console.WriteLine(convertedString.CreatingRepresentationOfNumberInNewSystem());
        }

    }
}
