using System;

namespace HomeTask8
{
    /// <summary>
    ///Entering new users and executing commands
    /// </summary>
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                Invoker client = new Invoker();
                InputNewUser userData = new InputNewUser();
                DataCreator dataInfo = new DataCreator();
                userData.OutputNamesakes += WriteAndOutputNamesakes;
                bool escapeCondition = true;
                client.SetCommand(new InformationOnCommand(dataInfo, userData));
                while (escapeCondition)
                {
                    Console.WriteLine("Select an action (enter the action number in the console) :\n1) Enter new user \n2)Calculate the average age of users \n3)find the senior user \n4)find the most popular woman name");
                    string stringKey = Console.ReadLine();
                    switch (stringKey)
                    {
                        case "1":
                            userData.AddUsers();
                            break;
                        case "2":
                            client.CalculateAverageAge();
                            break;
                        case "3":
                            client.FindOldestUser();
                            break;
                        case "4":
                            client.FindPopularWomanName();
                            break;
                    }
                }
         }
         catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void WriteAndOutputNamesakes(object sender, NamesakesEventArgs e)
        {
            Console.WriteLine("Namesakes:");
            foreach (User namesake in e.Namesakes)
            {
                Console.WriteLine(namesake);
            }
            JSON_FileWriter writer = new JSON_FileWriter();
            writer.WriteToLsonFile(e.Namesakes, "C:\\Users\\Lenovo\\Source\\Repos\\NewRepo\\HomeTask8\\HomeTask8\\Users.json");
        }
    }
}
