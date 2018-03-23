using System;

namespace HomeTask6
{
    /// <summary> 
    /// We select and execute actions with the list of products
    /// </summary> 
    public class EntryPoint
    {
        static void Main(string[] args)
        {
            Storage listOfProducts = new Storage();
            bool escapeCondition = true;

            while (escapeCondition)
            {
                Console.WriteLine("Select an action (enter the action number in the console) : \n1) Add new product \n2) Calculate the number of types \n3) Calculate the total number of Products\n4) Calculate average price \n5) Calculate average cost of a particular type of product \n6) To exit, enter 'exit'");
                string stringKey = Console.ReadLine();
                switch (stringKey)
                {
                    case "1":
                        Console.WriteLine("Enter product type");
                        string type = Console.ReadLine();
                        Console.WriteLine("Enter the name of the product");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter the quantity of the product");
                        string quantity = Console.ReadLine();
                        Console.WriteLine("Enter the price per item");
                        string cost = Console.ReadLine();
                        try
                        {
                            listOfProducts.AddingNewItemToListOfProducts(type, name, quantity, cost);
                        }
                        catch (ArgumentOutOfRangeException)
                        {
                            Console.WriteLine("You entered invalid product parameters, the product is not added");
                        }
                        break;
                    case "2":
                        listOfProducts.CalculationType = new CountTypes();
                        Console.WriteLine(listOfProducts.counting(""));
                        break;
                    case "3":
                        listOfProducts.CalculationType = new CountAll();
                        Console.WriteLine(listOfProducts.counting(""));
                        break;
                    case "4":
                        try
                        {
                            listOfProducts.CalculationType = new AveragePrice();
                            Console.WriteLine(listOfProducts.counting(""));
                        }
                        catch (ArgumentOutOfRangeException)
                        {
                            Console.WriteLine("There are no products in the list of products.");
                        }
                        break;
                    case "5":
                        try
                        {
                            listOfProducts.CalculationType = new AveragePriceType();
                            Console.WriteLine("Enter product type");
                            string inputType = Console.ReadLine();
                            Console.WriteLine(listOfProducts.counting(inputType));
                        }
                        catch (ArgumentOutOfRangeException)
                        {
                            Console.WriteLine("There are no products with the specified type");
                        }
                        break;
                    case "exit":
                        escapeCondition = false;
                        break;
                }
            }
        }
    }
}
