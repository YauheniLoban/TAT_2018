using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12_04_2018
{
    struct Driver
    {
        public string firstName;
        public string lastName;
        public int age;
        public int cardNumber;

        public Driver(string _firstName,string _lastName,int _age, int _cardNumber)
        {
            age = _age;
            cardNumber = _cardNumber;
            firstName = _firstName;
            lastName = _lastName;
        }

        public void OutputInformation()
        {
            Console.WriteLine("First Name :" + firstName + " Last Name :" + lastName + " Age :" + age + " Card Number :" + cardNumber);
        }
    }
}
