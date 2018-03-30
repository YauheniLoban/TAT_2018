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
            salon.OutputInformation();
            ProspectiveCar carOfDream = new ProspectiveCar();
            carOfDream.mark = "Ford";
            carOfDream.model = "JS52";
            carOfDream.volume = "";
            carOfDream.typeOfBody = "";
            carOfDream.transmissionType = "";
            carOfDream.salonType = "";
            carOfDream.power = "";
            carOfDream.engineType = "";
            carOfDream.climateControl = "";
            Invoker newInvoker = new Invoker();
            newInvoker.SetCommand(new SimilarOptionsInCatalog(salon, carOfDream));
            Console.WriteLine("Сработало ?");
            foreach (Car next in newInvoker.Execute())
            {
                next.OutInformationAboutCar();
            }
            newInvoker.SetCommand(new SimilarOptionsInStock(salon, carOfDream));
            foreach (Car next in newInvoker.Execute())
            {
                next.OutInformationAboutCar();
            }
            Console.WriteLine("После добавления");
            newInvoker.SetCommand(new AddingItemToFile(salon, carOfDream));
            foreach (Car next in newInvoker.Execute())
            {
                next.OutInformationAboutCar();
            }
            /*    SimilarOptionsInStock information = new SimilarOptionsInStock();
                SimilarOptionsInCatalog informationInCatalog = new SimilarOptionsInCatalog();
                Console.WriteLine("Работай давай");
                foreach (Car next in information.Execute(salon, carOfDream))
                {
                    next.OutInformationAboutCar();
                }
                Console.WriteLine("список похожих в каталоге");
                foreach (Car next in informationInCatalog.Execute(salon, carOfDream))
                {
                    next.OutInformationAboutCar();
                }


                Console.WriteLine("Добавили новый элемент в фаил и вернули то что теперь на складе ");
                AddingItemToFile addInformatio = new AddingItemToFile();
                foreach (Car next in addInformatio.Execute(salon, carOfDream))
                {
                    next.OutInformationAboutCar();
                }*/
        }
    }
}
