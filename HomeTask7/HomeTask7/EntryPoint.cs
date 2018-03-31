using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace HomeTask7
{
    public class EntryPoint
    {
        static void Main(string[] args)
        {
            CarShowroom salon = new CarShowroom(args[0], args[1]);
            salon.ReadJsonFile();
            bool escapeCondition = true;
            Invoker newInvoker = new Invoker();
            ProspectiveCar wantedCar = new ProspectiveCar();
            while (escapeCondition)
            {
                Console.WriteLine("Select an action (enter the action number in the console) :\n1: Enter the desired characteristics for car search \n2:Check stock for cars with similar characteristics \n3:Check catalog for cars with similar characteristics \n4)Select and add a Car from variants that satisfy the condition \n5)View information from the catalog and stock \nTo exit, enter 'exit'");
                string stringKey = Console.ReadLine();
                switch (stringKey)
                {
                    case "1":
                        wantedCar.EnteringTheDesiredCharacteristics();
                        break;
                    case "2":
                        try
                        {
                            newInvoker.SetCommand(new SimilarOptionsInStock(salon, wantedCar));
                            foreach (Car next in newInvoker.Execute())
                            {
                                next.OutInformationAboutCar();
                            }
                        }
                        catch(ArgumentOutOfRangeException)
                        {
                            Console.WriteLine("Unfortunately at the moment there are no machines in the stock that satisfy the entered characteristics. You can check the catalog for a match or see all possible options in the catalog");
                        }
                        break;

                    case "3":
                        try
                        {
                            newInvoker.SetCommand(new SimilarOptionsInCatalog(salon, wantedCar));
                            foreach (Car next in newInvoker.Execute())
                            {
                                next.OutInformationAboutCar();
                            }
                        }
                        catch  (ArgumentOutOfRangeException)
                        {
                            Console.WriteLine("Unfortunately there are no machines in your catalog that meet your requirements.");
                        }
                        break;

                    case "4":
                        try
                        {   
                            newInvoker.SetCommand(new SimilarOptionsInCatalog(salon, wantedCar));
                            List<Car> similarCars = new List<Car>(newInvoker.Execute());
                            Console.WriteLine("Cars matching your request:");
                            for(int i=0;i<similarCars.Count;i++)
                            {
                                Console.WriteLine(i + 1+":");
                                similarCars[i].OutInformationAboutCar();
                            }
                            Console.WriteLine("Choose which model you want to order (add to stock) and enter her number");
                            bool selectionСondition = true;
                               while (selectionСondition)
                            {
                                int numberOfCar = int.Parse(Console.ReadLine());
                                if(numberOfCar< similarCars.Count|| numberOfCar > similarCars.Count)
                                {
                                    Console.WriteLine("You entered an invalid number");
                                }
                                else
                                {
                                    selectionСondition = false;
                                    wantedCar.mark = similarCars[numberOfCar - 1].GetType().Name;
                                    wantedCar.climateControl = similarCars[numberOfCar - 1].climateControl;
                                    wantedCar.engineType = similarCars[numberOfCar - 1].engineType;
                                    wantedCar.model= similarCars[numberOfCar - 1].model;
                                    wantedCar.power = similarCars[numberOfCar - 1].power;
                                    wantedCar.salonType = similarCars[numberOfCar - 1].salonType;
                                    wantedCar.transmissionType = similarCars[numberOfCar - 1].transmissionType;
                                    wantedCar.typeOfBody = similarCars[numberOfCar - 1].typeOfBody;
                                    wantedCar.volume = similarCars[numberOfCar - 1].volume;
                                }
                             }
                                newInvoker.SetCommand(new AddingItemToFile(salon, wantedCar));
                                Console.WriteLine("The selected car was added to the stock");
                                foreach (Car next in newInvoker.Execute())
                                {
                                    next.OutInformationAboutCar();
                                }
                          //  wantedCar = null;
                        }
                        catch  (ArgumentOutOfRangeException)
                        {
                            Console.WriteLine("Unfortunately there are no machines in your catalog that meet your requirements.");
                        }
                        break;

                    case "5":
                        salon.OutputInformation();
                        break;     

                    case "exit":
                    escapeCondition = false;
                    break;

                }
            }
        /*    newInvoker.SetCommand(new SimilarOptionsInCatalog(salon, wantedCar));
            Console.WriteLine("Сработало ?");
            foreach (Car next in newInvoker.Execute())
            {
                next.OutInformationAboutCar();
            }
            newInvoker.SetCommand(new SimilarOptionsInStock(salon, wantedCar));
            foreach (Car next in newInvoker.Execute())
            {
                next.OutInformationAboutCar();
            }
            Console.WriteLine("После добавления");
            newInvoker.SetCommand(new AddingItemToFile(salon, wantedCar));
            foreach (Car next in newInvoker.Execute())
            {
                next.OutInformationAboutCar();
            }*/
        }
    }
}
