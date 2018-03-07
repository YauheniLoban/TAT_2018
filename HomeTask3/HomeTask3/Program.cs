using DevTask3;
using System;

namespace Task_Dev3
{
    /// <summary> 
    /// We accept from the command line two arguments: 
    /// 1) the number that needs to be transferred to another system of calculation 
    /// 2) the foundation of a new system of calculus 
    /// </summary> 
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try 
            {
                int digitForTranslation;
                int foundationOfNewsystem;
                digitForTranslation = Int32.Parse(args[0]);
                foundationOfNewsystem = Int32.Parse(args[1]);
                if (foundationOfNewsystem < 2 || foundationOfNewsystem > 20)
                {
                    throw new ArgumentOutOfRangeException();
                }    
                NumberInNewSystem convertedString = new NumberInNewSystem(digitForTranslation, foundationOfNewsystem);
                Console.WriteLine(convertedString.CreatingRepresentationOfNumberInNewSystem());
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("You entered the base of the new system not from the allowed range. Please enter another base of the new system ");
            }
            catch (FormatException)
            {
                Console.WriteLine("you entered incorrect arguments");
            }
            catch (Exception )
            {
                  Console.WriteLine("You entered an empty string");
            }
        }
    }
}
