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
                Console.WriteLine("Press 'Enter' for adding users or any other button for exit...");
                while (Console.ReadKey(true).KeyChar == '\r')
                {
                    userData.AddUsers();
                    client.SetCommand(new InformationOnCommand(dataInfo, userData));
                    client.CalculateAverageAge();
                    client.FindOldestUser();
                    client.FindPopularWomanName();
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
