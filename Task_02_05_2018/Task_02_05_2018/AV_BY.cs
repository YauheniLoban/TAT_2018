using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace Task_02_05_2018
{
    /// <summary>
    /// class to work with the main page av.by
    /// </summary>
    class AV_BY
    {
        ChromeDriver driver;
        Car car;

        public AV_BY(ChromeDriver driver, Car car)
        {
            this.car = car;
            this.driver = driver;
        }

        /// <summary>
        /// go to the list of models page for the selected brand
        /// </summary>
        public ListOfModelsPage GoToModelsPage()
        {
            if (CheckExistenceOfTheMark(car.Mark))
            {
                Locators locators = new Locators();
                IWebElement element = driver.FindElementByXPath(locators.CreateXPathForCarMark(car.Mark));
                ScrollWithOffset(element, 10, 10);               
                element.Click();
                return new ListOfModelsPage(driver, car);
            }
            else
            {
                throw new Exception("Chosen model is not available on the site");
            }
        }

        /// <summary>
        ///We check the availability of cars of the chosen mark
        /// </summary>
        /// <param name="carMark">chosen mark</param>
        public bool CheckExistenceOfTheMark(string carMark)
        {
            bool result = false;
            Locators locators = new Locators();
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            IWebElement element = wait.Until(drive => driver.FindElementByXPath(locators.allMarkButton));
            element.Click();
            var brandList = driver.FindElementsByXPath(locators.marks);
            foreach(IWebElement nextBrend in brandList)
            {
                if(carMark==nextBrend.FindElement(By.TagName(locators.markNameTag)).Text)
                {
                    result = true;
                }
            }
            return result;
        }

       private void ScrollWithOffset(IWebElement webElement, int x, int y)
        {
            string code = "window.scroll(" + (webElement.Location.X + x) + "," + (webElement.Location.Y + y) + ");";                                      
            ((IJavaScriptExecutor)driver).ExecuteScript(code, webElement, x, y);
        }
    }
}
