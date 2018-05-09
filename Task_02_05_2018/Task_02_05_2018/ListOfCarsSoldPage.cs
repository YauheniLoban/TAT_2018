using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_02_05_2018
{
    /// <summary>
    /// class to work with the list of cars sold page
    /// </summary>
    class ListOfCarsSoldPage
    {
        ChromeDriver driver;
        Car car;

        public ListOfCarsSoldPage(ChromeDriver driver, Car car)
        {
            this.car = car;
            this.driver = driver;
        }

        /// <summary>
        /// Find the minimum cost from the list of cars sold
        /// </summary>
        /// <returns>
        /// minimum price
        /// </returns>
        public int MinimumCostOfCar()
        {
            Locators loacators = new Locators();
            var carList = driver.FindElementsByXPath(loacators.briefInformationAboutCar);
            List<int> coasts = new List<int>();
            foreach (IWebElement next in carList)
            {
                string[] substrings = next.Text.Split();
                StringBuilder coast = new StringBuilder(substrings[2] + substrings[3]);
                coasts.Add(int.Parse(coast.ToString()));
            }
           return  coasts.Min(n => n);
        }
    }
}
