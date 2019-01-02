using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;


namespace ElementLocations
{
    class EntryPoint
    {
        static void Main()
        {
            IWebDriver driver = new ChromeDriver();

            string url = "http://testing.todvachev.com";

            driver.Navigate().GoToUrl(url);

            IWebElement image = driver.FindElement(By.CssSelector("#page-17 > div > p:nth-child(1) > a > img"));

            //Maximises the web page window
            driver.Manage().Window.Maximize();

            //gives the top left of the image
            Console.WriteLine(image.Location.X);
            Console.WriteLine(image.Location.Y);

            //get the width 
            Console.WriteLine(image.Size.Width);
            //Get the height
            Console.WriteLine(image.Size.Height);

        
        }
    }
}
