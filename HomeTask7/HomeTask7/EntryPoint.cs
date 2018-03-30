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
            SimilarOptionsInStock information = new SimilarOptionsInStock();
            SimilarOptionsInCatalog informationInCatalog = new SimilarOptionsInCatalog();
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
            Console.WriteLine("Работай давай");
            foreach (Car next in information.Execute(salon, carOfDream))
            {
                next.whoami();
            }
            Console.WriteLine("список похожих в каталоге");
            foreach (Car next in informationInCatalog.Execute(salon, carOfDream))
            {
                next.whoami();
            }


            Console.WriteLine("Добавили новый элемент в фаил и вернули то что теперь на складе ");
            AddingItemToFile addInformatio = new AddingItemToFile();
            foreach (Car next in addInformatio.Execute(salon, carOfDream))
            {
                next.whoami();
            }
        }
    }
}
