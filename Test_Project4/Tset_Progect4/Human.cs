using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tset_Progect4
{
    public class Human
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public Human(string name, string surname, int age)
        {
            if (age > 0)
            {
                Name = name;
                Surname = surname;
                Age = age;
            }
            else
            {
                throw new ArgumentException("Invalid age");
            }                   
        }

        public override string ToString()
        {
            return "First Name :" + Name + " Last Name :" + Surname + " Age:" + Age;
        }

    }
}
