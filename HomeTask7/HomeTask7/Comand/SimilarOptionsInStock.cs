using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask7
{
    class SimilarOptionsInStock : IComand
    {
        public CarShowroom carShowroom;
        public ProspectiveCar prorespectiveCar;
        public SimilarOptionsInStock(CarShowroom carShowroomSet, ProspectiveCar prorespectiveCarSet)
        {
            carShowroom = carShowroomSet;
            prorespectiveCar = prorespectiveCarSet;
        }
        /*   public IEnumerable<Car> Execute(CarShowroom score , ProspectiveCar prorespectiveCar )
           {
             IEnumerable<Car> possibleOptions = from nextCar in score.stock
             where (prorespectiveCar.mark == string.Empty || nextCar.GetType().Name == prorespectiveCar.mark)
             && (prorespectiveCar.model == string.Empty || nextCar.model == prorespectiveCar.model)
             && (prorespectiveCar.typeOfBody == string.Empty || nextCar.typeOfBody == prorespectiveCar.typeOfBody)
             && (prorespectiveCar.climateControl == string.Empty || nextCar.climateControl == prorespectiveCar.climateControl)
             && (prorespectiveCar.engineType == string.Empty || nextCar.engineType == prorespectiveCar.engineType)
             && (prorespectiveCar.power == string.Empty || nextCar.power == prorespectiveCar.power)
             && (prorespectiveCar.salonType == string.Empty || nextCar.salonType == prorespectiveCar.salonType)
             && (prorespectiveCar.volume == string.Empty || nextCar.volume == prorespectiveCar.volume)
             && (prorespectiveCar.transmissionType == string.Empty || nextCar.transmissionType == prorespectiveCar.transmissionType)
             select nextCar;*/
        public IEnumerable<Car> Execute()
        {
            IEnumerable<Car> possibleOptions = from nextCar in carShowroom.stock
            where (prorespectiveCar.mark == string.Empty || nextCar.GetType().Name == prorespectiveCar.mark)
            && (prorespectiveCar.model == string.Empty || nextCar.model == prorespectiveCar.model)
            && (prorespectiveCar.typeOfBody == string.Empty || nextCar.typeOfBody == prorespectiveCar.typeOfBody)
            && (prorespectiveCar.climateControl == string.Empty || nextCar.climateControl == prorespectiveCar.climateControl)
            && (prorespectiveCar.engineType == string.Empty || nextCar.engineType == prorespectiveCar.engineType)
            && (prorespectiveCar.power == string.Empty || nextCar.power == prorespectiveCar.power)
            && (prorespectiveCar.salonType == string.Empty || nextCar.salonType == prorespectiveCar.salonType)
            && (prorespectiveCar.volume == string.Empty || nextCar.volume == prorespectiveCar.volume)
            && (prorespectiveCar.transmissionType == string.Empty || nextCar.transmissionType == prorespectiveCar.transmissionType)
            select nextCar;

            return possibleOptions;
        }
    }
}
