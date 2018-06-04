using System;
using HomeTask11;

namespace ConsoleClient
{
    class EntryPoint
    {
        /// <summary>
        /// Parameters for the date are entered. After that, the number of days elapsed from the beginning of our era is calculated
        /// </summary>                    
        static void Main(string[] args)
        {
            try
            {
                int day, month, year;           
                Console.WriteLine("Enter the day of the date");
                day = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the month of the date");
                month = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the year of the date");
                year = Convert.ToInt32(Console.ReadLine());
                DateConverterWebService webServis = new DateConverterWebService();
                Console.WriteLine("Number of days after the beginning of our era: " + webServis.CountThePastNumberOfDays(day, month, year));
            }
            catch (ArgumentException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
