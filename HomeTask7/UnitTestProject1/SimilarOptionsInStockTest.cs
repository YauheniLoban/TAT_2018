using System;
using NUnit.Framework;
using HomeTask7;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestFixture]
    public class SimilarOptionsInStockTest
    {
        [TestCase("Missing Brand", "C:\\Users\\Lenovo\\Source\\Repos\\NewRepo\\HomeTask7\\UnitTestProject1\\TestCatalog.json", "C:\\Users\\Lenovo\\Source\\Repos\\NewRepo\\HomeTask7\\UnitTestProject1\\TestStock.json")]
        public void SimilarOptionsInStockTest_Exception(string missingBrand, string wayToCatalog, string wayToStock)
        {
            CarShowroom salon = new CarShowroom(wayToCatalog, wayToStock);
            salon.ReadJsonFile();
            Invoker newInvoker = new Invoker();
            ProspectiveCar wantedCar = new ProspectiveCar();
            wantedCar.mark = missingBrand;
            wantedCar.model = "";
            wantedCar.typeOfBody = "";
            wantedCar.transmissionType = "";
            wantedCar.engineType = "";
            wantedCar.volume = "";
            wantedCar.power = "";
            wantedCar.climateControl = "";
            wantedCar.salonType = "";
            newInvoker.SetCommand(new SimilarOptionsInStock(salon, wantedCar));
            Assert.Throws<ArgumentOutOfRangeException>
            (
              () => newInvoker.Execute()
            );
        }

        [TestCase(new string[] { "Ford" }, new string[] { "", "JS52" }, new string[] { "", "Param1" }, new string[] { "", "Param2" }, new string[] { "", "Param3" }, new string[] { "", "Param4" }, new string[] { "", "50 horses" }, new string[] { "", "Param5" }, new string[] { "", "Leze" }, "C:\\Users\\Lenovo\\Source\\Repos\\NewRepo\\HomeTask7\\UnitTestProject1\\TestCatalog.json", "C:\\Users\\Lenovo\\Source\\Repos\\NewRepo\\HomeTask7\\UnitTestProject1\\TestStock.json")]
        public void SimilarOptionsInStock_Test(string[] brand, string[] model, string[] typeOfBody, string[] transmissionType, string[] engineType, string[] volume, string[] power, string[] climateContro, string[] salonType, string wayToCatalog, string wayToStock)
        {
            CarShowroom salon = new CarShowroom(wayToCatalog, wayToStock);
            salon.ReadJsonFile();
            Invoker newInvoker = new Invoker();
            ProspectiveCar result = new ProspectiveCar();
            ProspectiveCar wantedCar = new ProspectiveCar();
            wantedCar.mark = brand[0];
            wantedCar.model = model[0];
            wantedCar.typeOfBody = typeOfBody[0];
            wantedCar.transmissionType = transmissionType[0];
            wantedCar.engineType = engineType[0];
            wantedCar.volume = volume[0];
            wantedCar.power = power[0];
            wantedCar.climateControl = climateContro[0];
            wantedCar.salonType = salonType[0];
            newInvoker.SetCommand(new SimilarOptionsInStock(salon, wantedCar));
            List<Car> similarCars = new List<Car>(newInvoker.Execute());
            Assert.True(similarCars[0].GetType().Name == brand[0] && similarCars[0].model == model[1] && similarCars[0].typeOfBody == typeOfBody[1] &&
                similarCars[0].transmissionType == transmissionType[1] && similarCars[0].engineType == engineType[1] && similarCars[0].volume == volume[1] &&
                similarCars[0].power == power[1] && similarCars[0].climateControl == climateContro[1] && similarCars[0].salonType == salonType[1]);
        }
    }
}
