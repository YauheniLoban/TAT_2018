using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Task_24_04_2018
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            ChromeDriver driver = new ChromeDriver();
            TimeSpan waitingTime = new TimeSpan(0, 0, 20);
            driver.Manage().Timeouts().ImplicitWait = waitingTime;
            driver.Manage().Timeouts().PageLoad = waitingTime;
            driver.Navigate().GoToUrl("https://vk.com/login?act=mobile&hash=ecd052c43b90e817dd85b2df4178");
            XPathLocators locators = new XPathLocators();
            IWebElement element = driver.FindElementByXPath(locators.loginField);
            element.Click();
            element.SendKeys("+375292022934");
            element = driver.FindElementByXPath(locators.passwordField);
            element.Click();
            element.SendKeys("Tdutybq1");
            element = driver.FindElementByXPath(locators.loginButton);
            element.Click();
            element = driver.FindElementByXPath(locators.messageButton);
            element.Click();
            element = driver.FindElementByXPath(locators.firstDialogue);
            element.Click();
            element = driver.FindElementByXPath(locators.lastMessageInDialog);
            Console.WriteLine(element.Text);
            element = driver.FindElementByXPath(locators.topMenu);
            element.Click();
            element = driver.FindElementByXPath(locators.logoutButton);
            element.Click();
            driver.Quit();
        }
    }
}
