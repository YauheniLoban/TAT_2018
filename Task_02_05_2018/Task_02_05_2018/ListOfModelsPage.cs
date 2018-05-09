using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Linq;

namespace Task_02_05_2018
{
    /// <summary>
    /// class to work with the list of models page
    /// </summary>
    class ListOfModelsPage
    {
        ChromeDriver driver;
        Car car;

        public ListOfModelsPage(ChromeDriver driver, Car car)
        {
            this.car = car;
            this.driver = driver;
        }

        /// <summary>
        /// List all models in descending order of the number of cars sold
        /// </summary>
        public void DisplayAllModels()
        {
            Locators locators = new Locators();
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            var brandList = wait.Until(drive => driver.FindElementsByXPath(locators.marks));
            var sortedBrandList = from u in brandList
                                  orderby Int32.Parse(u.FindElement(By.TagName(locators.numberОfСarsTag)).Text) descending
                                  select u;
            foreach (IWebElement nextBrend in sortedBrandList)
            {
                Console.WriteLine("model name: " + nextBrend.FindElement(By.TagName(locators.modelNameTag)).Text + " number of cars of this brand sold : " + nextBrend.FindElement(By.TagName(locators.numberОfСarsTag)).Text);
            }             
        }

        /// <summary>
        /// go to the list of cars sold
        /// </summary>
        public ListOfCarsSoldPage GoToSoldCars()
        {
            Locators locators = new Locators();
            IWebElement element = driver.FindElementByXPath(locators.CreateXPathForCarMark(car.Model));
            element.Click();
            return new ListOfCarsSoldPage(driver, car);
        }
    }
}
