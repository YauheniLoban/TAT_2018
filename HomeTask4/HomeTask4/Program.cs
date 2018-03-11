using System;

namespace HomeTask4
{
    /// <summary>
    /// We accept from the comand line the path to the file
    /// </summary>
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                ParserForXmlFile str = new ParserForXmlFile(args[0]);
                str.OutputtingDataToConsole();
            }
            catch (FormatException)
            {
                Console.WriteLine("you entered incorrect arguments");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("you entered the wrong path to the file");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("you entered incorrect arguments");
            }
        }
    }
}
