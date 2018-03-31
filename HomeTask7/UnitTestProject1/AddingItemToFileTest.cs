using System;
using NUnit.Framework;
using HomeTask7;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestFixture]
    public class AddingItemToFileTest
    {
        [TestCase("C:\\Users\\Lenovo\\Source\\Repos\\NewRepo\\HomeTask7\\UnitTestProject1\\TestCatalog.json", "C:\\Users\\Lenovo\\Source\\Repos\\NewRepo\\HomeTask7\\UnitTestProject1\\TestStock.json")]
        public void AddingItemToFile_Exception( string wayToCatalog, string wayToStock)
        {
            CarShowroom salon = new CarShowroom(wayToCatalog, wayToStock);
            salon.ReadJsonFile();
            Invoker newInvoker = new Invoker();
            ProspectiveCar wantedCar = new ProspectiveCar();
            newInvoker.SetCommand(new AddingItemToFile(salon, wantedCar));
            Assert.Throws<ArgumentOutOfRangeException>
            (
              () => newInvoker.Execute()
            );
        }

        [TestCase("Hyndai", "J2", "Black","Type1","Type1","40","450", "without","Type2", "C:\\Users\\Lenovo\\Source\\Repos\\NewRepo\\HomeTask7\\UnitTestProject1\\TestCatalog.json", "C:\\Users\\Lenovo\\Source\\Repos\\NewRepo\\HomeTask7\\UnitTestProject1\\TestStock.json")]
        public void AddingItemToFile_Test(string brand ,string model ,string typeOfBody ,string transmissionType ,string engineType ,string volume, string power, string climateControl, string salonType, string wayToCatalog, string wayToStock)
        {
            CarShowroom salon = new CarShowroom(wayToCatalog, wayToStock);
            salon.ReadJsonFile();
            Invoker newInvoker = new Invoker();
            ProspectiveCar result = new ProspectiveCar();
            ProspectiveCar wantedCar = new ProspectiveCar();
            wantedCar.mark = brand;
            wantedCar.model = model;
            wantedCar.typeOfBody = typeOfBody;
            wantedCar.transmissionType = transmissionType;
            wantedCar.engineType = engineType;
            wantedCar.volume = volume;
            wantedCar.power = power;
            wantedCar.climateControl = climateControl;
            wantedCar.salonType = salonType;
            newInvoker.SetCommand(new AddingItemToFile(salon, wantedCar));
            List<Car> similarCars = new List<Car>(newInvoker.Execute());
            int lastElent = similarCars.Count-1;
            Assert.True(similarCars[lastElent].GetType().Name == brand && similarCars[lastElent].model == model && similarCars[lastElent].typeOfBody == typeOfBody &&
               similarCars[lastElent].transmissionType == transmissionType && similarCars[lastElent].engineType == engineType && similarCars[lastElent].volume == volume &&
               similarCars[lastElent].power == power && similarCars[lastElent].climateControl == climateControl && similarCars[lastElent].salonType == salonType);
        }

    }
}
