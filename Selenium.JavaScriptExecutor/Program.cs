using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Selenium.JavaScriptExecutor
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://itechcraft.com/");
            driver.Manage().Window.Maximize();

            

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            IWebElement footer = driver.FindElement(By.Id("section__footer"));

            js.ExecuteScript("arguments[0].scrollIntoView(); ", footer);
           
           

        }

       
    }
}
