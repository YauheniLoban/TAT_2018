using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask7
{
    abstract public class Car
    {
        public string model { get; set; }
        public string typeOfBody { get; set; }
        public string transmissionType { get; set; }
        public string engineType { get; set; }
        public string volume { get; set; }
        public string power { get; set; }
        public string climateControl { get; set; }
        public string salonType { get; set; }

        public void whoami()
        {
            Console.WriteLine(model + " " + volume + " " + typeOfBody + " " + transmissionType + " " + power + "" + climateControl + " " + this.GetType().Name);
        }

        public void fillingFields(JObject carObject)
        {
            model = carObject["model"].Value<string>();
            typeOfBody = carObject["typeOfBody"].Value<string>();
            transmissionType = carObject["transmissionType"].Value<string>();
            engineType = carObject["engineType"].Value<string>();
            volume = carObject["volume"].Value<string>();
            power = carObject["power"].Value<string>();
            climateControl = carObject["climateControl"].Value<string>();
            salonType = carObject["salonType"].Value<string>();
        }
    }
}
