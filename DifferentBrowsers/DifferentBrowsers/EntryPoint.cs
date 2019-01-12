using OpenQA.Selenium.Chrome;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Opera;

namespace DifferentBrowsers
{
    class EntryPoint
    {
        static void Main()
        {
            IWebDriver driverChrome = new ChromeDriver();
            IWebDriver driverIE = new InternetExplorerDriver();
            IWebDriver driverFireFox = new FirefoxDriver();
            //IWebDriver driverOpera = new OperaDriver();


            //Run all browsers at the same time
            string url = "http://google.com";
            driverChrome.Navigate().GoToUrl(url);
            driverIE.Navigate().GoToUrl(url);
            driverFireFox.Navigate().GoToUrl(url);
            //driverOpera.Navigate().GoToUrl(url);



            //driverChrome.Quit();
            //driverIE.Quit();
            //driverOpera.Quit();

        
        }
    }
}
