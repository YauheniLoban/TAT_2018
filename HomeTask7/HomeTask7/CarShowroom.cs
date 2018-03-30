using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask7
{
    class CarShowroom
    {
        public List<Car> catalog;
        public List<Car> stock;
        public  string wayToCatalog;
        public string wayToStock;

        public CarShowroom(string toCatalog, string toStock)
        {
            wayToCatalog = toCatalog;
            wayToStock = toStock;
        }

        public void ReadJsonFile()
        {
            CarConverter converter = new CarConverter();
            catalog = JsonConvert.DeserializeObject<List<Car>>(File.ReadAllText(wayToCatalog), converter);
            stock = JsonConvert.DeserializeObject<List<Car>>(File.ReadAllText(wayToStock), converter);
        }

        public void OutputInformation()
        {
            Console.WriteLine("Catalog :");
            foreach (Car c in catalog)
            {
                c.OutInformationAboutCar();
            }

            Console.WriteLine("Stoch :");
            foreach (Car c in stock)
            {
                c.OutInformationAboutCar();
            }
        }
    }
}
