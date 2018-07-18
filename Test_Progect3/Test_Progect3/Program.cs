using System;
using System.IO;

namespace Test_Progect3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                if (args.Length < 2)
                {
                    throw new ArgumentException("Insufficient number of parameters");
                }
                FileFinder searcher = new FileFinder(args[0], args[1]);
                string[] files = searcher.AllFilesInFolder();                
                foreach (string nextFile in files)
                {
                    Console.WriteLine(nextFile);
                }                
            }
            catch(ArgumentException exeption)
            {
                Console.WriteLine(exeption.Message);
            }

            catch(DirectoryNotFoundException)
            {
                Console.WriteLine("the path to the folder is incorrect");
            }
        }
    }
}
