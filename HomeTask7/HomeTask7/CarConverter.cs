using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

namespace HomeTask7
{
    /// <summary> 
    /// A class for converting information from a file into objects of the required type
    /// </summary>
    public class CarConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override bool CanConvert(Type objectType)
        {
            return true;
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            List<Car> cars = new List<Car>();
            if (reader.TokenType == JsonToken.StartArray)
            {
                JArray array = JArray.Load(reader);
                foreach (JObject car in array.Children())
                {
                    cars.Add(Factory(car));
                }
                return cars;
            }

            throw new NotImplementedException();
        }

        private Car Factory(JObject carObject)
        {
            string markKey = carObject["mark"].Value<string>();
            Car newCar;

            switch (markKey)
            {
                case "Nissan":
                    newCar = new Nissan();
                    newCar.FillingFields(carObject);
                    break;

                case "Audi":
                    newCar = new Audi();
                    newCar.FillingFields(carObject);
                    break;

                case "Ford":
                    newCar = new Ford();
                    newCar.FillingFields(carObject);
                    break;

                case "Hyndai":
                    newCar = new Hyndai();
                    newCar.FillingFields(carObject);
                    break;

                default:
                    newCar = null;
                    break;
            }
            return newCar;
        }
    }
}
