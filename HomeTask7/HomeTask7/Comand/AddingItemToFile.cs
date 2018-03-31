using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask7
{
    class AddingItemToFile : IComand
    {
        public CarShowroom carShowroom;
        public ProspectiveCar prorespectiveCar;
        public AddingItemToFile (CarShowroom carShowroomSet , ProspectiveCar prorespectiveCarSet)
        {
            carShowroom = carShowroomSet;
            prorespectiveCar = prorespectiveCarSet;
        }
     
        public IEnumerable<Car> Execute()
        {
            List<Car> addedlist = new List<Car>();
            foreach (Car nextCar in carShowroom.stock)
            {
                ProspectiveCar addinlist = new ProspectiveCar();
                addinlist.mark = nextCar.GetType().Name;
                addinlist.model = nextCar.model;
                addinlist.power = nextCar.power;
                addinlist.salonType = nextCar.salonType;
                addinlist.transmissionType = nextCar.transmissionType;
                addinlist.typeOfBody = nextCar.typeOfBody;
                addinlist.volume = nextCar.volume;
                addinlist.engineType = nextCar.engineType;
                addinlist.climateControl = nextCar.climateControl;
                addedlist.Add(addinlist);
            }
            addedlist.Add(prorespectiveCar);
            File.WriteAllText(carShowroom.wayToStock, JsonConvert.SerializeObject(addedlist));
            carShowroom.ReadJsonFile();
            IEnumerable<Car> updatedInformationInFile = from nextCar in carShowroom.stock                                           
            select nextCar;
            return updatedInformationInFile;
        }

    }
}
