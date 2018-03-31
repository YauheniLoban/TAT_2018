using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask7
{
    /// <summary> 
    /// A class that defines how to add a new item to a file
    /// </summary>
    public class AddingItemToFile : IComand
    {
        public CarShowroom carShowroom;
        public ProspectiveCar prorespectiveCar;
        public AddingItemToFile(CarShowroom carShowroomSet, ProspectiveCar prorespectiveCarSet)
        {
            carShowroom = carShowroomSet;
            prorespectiveCar = prorespectiveCarSet;
        }

        public IEnumerable<Car> Execute()
        {
            if ((prorespectiveCar.climateControl == null) && prorespectiveCar.engineType == null && prorespectiveCar.mark == null &&
                prorespectiveCar.model == null && prorespectiveCar.power == null && prorespectiveCar.salonType == null && prorespectiveCar.transmissionType == null &&
                prorespectiveCar.typeOfBody == null && prorespectiveCar.volume == null)
            {
                throw new ArgumentOutOfRangeException();
            }
            List<Car> addedList = new List<Car>();
            foreach (Car nextCar in carShowroom.stock)
            {
                ProspectiveCar addInList = new ProspectiveCar();
                addInList.mark = nextCar.GetType().Name;
                addInList.model = nextCar.model;
                addInList.power = nextCar.power;
                addInList.salonType = nextCar.salonType;
                addInList.transmissionType = nextCar.transmissionType;
                addInList.typeOfBody = nextCar.typeOfBody;
                addInList.volume = nextCar.volume;
                addInList.engineType = nextCar.engineType;
                addInList.climateControl = nextCar.climateControl;
                addedList.Add(addInList);
            }
            addedList.Add(prorespectiveCar);
            File.WriteAllText(carShowroom.wayToStock, JsonConvert.SerializeObject(addedList));
            carShowroom.ReadJsonFile();
            IEnumerable<Car> updatedInformationInFile = from nextCar in carShowroom.stock
            select nextCar;
            return updatedInformationInFile;
        }

    }
}
