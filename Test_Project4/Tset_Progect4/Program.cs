using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tset_Progect4
{
    class Program
    {
        static void Main(string[] args)
        {
           
            HumanList humanlist = new HumanList();
            bool exitСondition = true;
            while(exitСondition)
            {
                string name;
                string surname;
                string ageString;
                int age;
                Console.WriteLine("Enter name");
                name = Console.ReadLine();
                Console.WriteLine("Enter surname");
                surname = Console.ReadLine();
                Console.WriteLine("Enter age");
                ageString = Console.ReadLine();
                if(Int32.TryParse(ageString,out age))
                {
                    humanlist.AddHuman(new Human(name, surname, age));
                    humanlist.DisplayInformationAboutAllPeople();
                    Console.WriteLine("Average Age: "+ humanlist.AverageAge());
                    Console.WriteLine("Min Age: " + humanlist.MinAge());
                    Console.WriteLine("Max Age: " + humanlist.MaxAge());
                }
                else
                {
                    Console.WriteLine("age is incorrect");
                }
            }
        }
    }
}
