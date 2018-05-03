using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Task_23_04_2018
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            ChromeDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.tut.by/?crnd=88641");
            IWebElement element = driver.FindElementByXPath("//*[@data-ua-hash=\"main_news~1\"]");
            element.Click();
            driver.PrintTextOfArticle();
            driver.BackToHomePageTUTBY();
            Console.WriteLine("|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
              
            element = driver.FindElementByXPath("//*[@data-ua-hash=\"main_news~2\"]");
            element.Click();
            driver.PrintTextOfArticle();
            driver.BackToHomePageTUTBY();

            Console.WriteLine("|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
            
            element = driver.FindElementByXPath("//*[@data-ua-hash=\"main_news~3\"]");
            element.Click();
            driver.PrintTextOfArticle();
            driver.BackToHomePageTUTBY();            
            Console.WriteLine("|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");

            element = driver.FindElementByXPath("//*[@data-ua-hash=\"main_news~4\"]");
            element.Click();
            driver.PrintTextOfArticle();
            driver.BackToHomePageTUTBY();
            driver.Quit();
        }
    }
}
