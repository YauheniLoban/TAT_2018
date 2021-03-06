﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask7
{
    /// <summary> 
    /// Class describing the general characteristics of the Car
    /// </summary>
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

        /// <summary> 
        /// output of Car characteristics
        /// </summary>
        public void OutInformationAboutCar()
        {
            Console.WriteLine("car make:" + this.GetType().Name + "  car model:" + model + "  body type:" + typeOfBody + 
            "  volume:" + volume + "   transmission type:" + transmissionType + "   power:" + power 
            + "   way to manage the climate" + climateControl + "  type of engine" + engineType + "  type of salon:" + salonType);
        }

        /// <summary> 
        /// method for filling the characteristics of the Car based on information from the file
        /// </summary>
        public void FillingFields(JObject carObject)
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
