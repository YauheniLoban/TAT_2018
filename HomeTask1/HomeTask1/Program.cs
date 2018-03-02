using System;

namespace DevTask1
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
           
            if (args.Length != 1) //Checking the condition for the argument
            {
                Console.WriteLine("Wrong number of arguments");
                return;
            }
            if (args.Length == 0) //Checking for the presence of elements in a row
            {
                Console.WriteLine("Enter a non-empty string");
                return;
            }
            EntryPoint need = new EntryPoint();
            var commandLineArgument = args[0].ToCharArray();
            Console.WriteLine(need.MaximumNumberofDuplicates(commandLineArgument));
        }
        //Function for finding the maximum number of repeating identical elements in succession
        int MaximumNumberofDuplicates(char[] transmittedString) 
        {
            int maximumAmount = 0, temp = 0;
            for (int i = 0; i < transmittedString.Length - 1; i++)
            {   
                if (transmittedString[i] == transmittedString[i + 1]) temp++; //Check for a match between the current and the next element
                else temp = 0; //Assign the counter to zero if the elements do not match
                if (temp > maximumAmount) //Check if this sequence is longer
                {
                    maximumAmount = temp;
                }
            }
            return maximumAmount + 1;
        }
    }
}
