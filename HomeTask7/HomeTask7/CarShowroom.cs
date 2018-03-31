using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace HomeTask7
{
    /// <summary> 
    /// Class intended for storage and work and information about the cathode and stock
    /// </summary>
    public class CarShowroom
    {
        public List<Car> catalog;
        public List<Car> stock;
        public string wayToCatalog;
        public string wayToStock;

        public CarShowroom(string toCatalog, string toStock)
        {
            wayToCatalog = toCatalog;
            wayToStock = toStock;
        }

        /// <summary> 
        /// Converts information from a  JSON file to a list of Car
        /// </summary> 
        public void ReadJsonFile()
        {
            CarConverter converter = new CarConverter();
            catalog = JsonConvert.DeserializeObject<List<Car>>(File.ReadAllText(wayToCatalog), converter);
            stock = JsonConvert.DeserializeObject<List<Car>>(File.ReadAllText(wayToStock), converter);
        }

        /// <summary> 
        /// displays in the console information about all Car read from the file
        /// </summary> 
        public void OutputInformation()
        {
            this.ReadJsonFile();
            Console.WriteLine("Catalog :");
            foreach (Car nextCar in catalog)
            {
                nextCar.OutInformationAboutCar();
            }

            Console.WriteLine("Stoch :");
            foreach (Car nextCar in stock)
            {
                nextCar.OutInformationAboutCar();
            }
        }
    }
}
