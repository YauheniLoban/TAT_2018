using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_23_04_2018
{
    public static class TUTBYComand
    {
        public static void BackToHomePageTUTBY(this ChromeDriver driver)
        {
            IWebElement element = driver.FindElementByLinkText("TUT.BY");
            element.Click();
        }

        public static void PrintTextOfArticle(this ChromeDriver driver)
        {
            IWebElement element = driver.FindElementById("article_body");
            Console.WriteLine(element.Text); 
        }
    }
}
