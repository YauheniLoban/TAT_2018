using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask8
{
    class InformationOnCommand : ICommand
    {
        DataCreator dataInfo;
        InputNewUser input;

        public InformationOnCommand(DataCreator dataCreater, InputNewUser inputNewUser)
        {
            dataInfo = dataCreater;
            input = inputNewUser;
        }

        public void ExecuteAverageAge()
        {
            Console.WriteLine("Average age: " + dataInfo.AverageAge(input.users));
        }

        public void ExecuteOldestUser()
        {
            Console.WriteLine("Oldest users: ");
            foreach (User user in dataInfo.OldestUsers(input.users))
            {
                Console.WriteLine(user);
            }
        }

        public void ExecutePopularWomanName()
        {
            if (dataInfo.MostPopularWomanName(input.users) != null)
            {
                Console.WriteLine("Popular woman name: ");
                foreach (string name in dataInfo.MostPopularWomanName(input.users))
                {
                    Console.WriteLine(name);
                }
            }
        }
    }
}
