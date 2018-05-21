using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tset_Progect4
{
    class HumanList
    {
        List<Human> humanList = new List<Human>();

        public void AddHuman(Human human)
        {
            humanList.Add(human);
        }

        public void DisplayInformationAboutAllPeople()
        {
            foreach(Human nextHuman in humanList)
            {
                Console.WriteLine(nextHuman.ToString());
            }
        }

        public double AverageAge()
        {
            double avarageAge = humanList.Average(human => human.Age);           
            return Math.Round(avarageAge, 2);
        }

        public double MaxAge()
        {
            return humanList.Max(human => human.Age);
        }

        public double MinAge()
        {
            return humanList.Min(human => human.Age);
        }
    }
}
