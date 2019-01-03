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

            IWebElement content = driver.FindElement(By.CssSelector("#page-17 > div"));

            //Enter the value from https://www.w3schools.com/cssref/ here
            SetStyle(driver, content, "color", "green");
                   
        }
        static void SetStyle(IWebDriver driver, IWebElement element, string style, string styleValue)
        {
            string script = String.Format ("arguments[0].style[\"{0}\"] = \"{1}\"", style, styleValue);
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;
            jsExecutor.ExecuteScript(script, element);
        }
    }
}
