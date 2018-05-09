using OpenQA.Selenium.Chrome;
using System;

namespace Task_02_05_2018
{
    /// <summary>
    /// Go to the av.by and output a list of models with the number of machines sold for the brand
    /// </summary>
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the brand you are interested in");
                string carBrand = Console.ReadLine();
                ChromeDriver driver = new ChromeDriver();
                driver.Navigate().GoToUrl("https://av.by/");
                Car car = new Car(carBrand, "");
                AV_BY mainPage = new AV_BY(driver, car);
                ListOfModelsPage listOfModelsPage = mainPage.GoToModelsPage();
                listOfModelsPage.DisplayAllModels();
                driver.Quit();
            }
           catch(Exception exeption)
            {
               Console.WriteLine(exeption.Message);
            }
        }
    }
}
