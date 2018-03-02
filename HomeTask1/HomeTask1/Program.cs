using System;

namespace DevTask1
{
    /// <summary> 
    /// Class MaxNumberOfDuplicates
    /// Searches for the maximum number of identical items in a row
    /// </summary> 
    class MaxNumberOfDuplicates 
    {
        static void Main(string[] args)
        {
            if (args.Length != 1) // Checking the condition for the argument
            {
                Console.WriteLine("Wrong number of arguments");
                return;
            }

            if (args.Length == 0) // Checking for the presence of elements in a row
            {
                Console.WriteLine("Enter a non-empty string");
                return;
            }

            MaxNumberOfDuplicates EntryPointObject = new MaxNumberOfDuplicates();
            Console.WriteLine(EntryPointObject.MaximumNumberofDuplicates(args[0]));
        }


        /// <summary> 
        /// Method MaximumNumberofDuplicates 
        /// Function for finding the maximum number of repeating identical elements in succession
        /// </summary> 
        /// <param name="transmittedString">String, which was inputed</param> 
        /// <returns>The largest number of identical characters in succession</returns>
        int MaximumNumberofDuplicates(String transmittedString) 
        {
            int maximumAmount = 0, tempMaxNumber = 0;

            for (int i = 0; i < transmittedString.Length - 1; i++)
            {
                if (transmittedString[i] == transmittedString[i + 1])
                {
                    tempMaxNumber++; // Check for a match between the current and the next element
                }
                else
                {
                    tempMaxNumber = 0; // Assign the counter to zero if the elements do not match
                }

                if (tempMaxNumber > maximumAmount) //Check if this sequence is longer
                {
                    maximumAmount = tempMaxNumber;
                }
            }

            return maximumAmount + 1;
        }
    }
}
