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
        public IEnumerable<Car> Execute(CarShowroom score, ProspectiveCar prorespectiveCar)
        {
            List<Car> addedlist = new List<Car>();
            foreach (Car nextCar in score.stock)
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
            File.WriteAllText(score.wayToStock, JsonConvert.SerializeObject(addedlist));
            score.ReadJsonFile();
            IEnumerable<Car> updatedInformationInFile = from nextCar in score.stock                                           
            select nextCar;
            return updatedInformationInFile;
        }

    }
}
