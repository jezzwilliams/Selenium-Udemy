using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;
using System.Threading;

namespace SeleniumScreenshots
{
    class EntryPoint
    {
        static void Main()
        {
            //Initiate web driver
            IWebDriver chrome = new ChromeDriver();

            //if our screenshot folder doesnt exist use this one
            string screenshotDirectory = Directory.GetCurrentDirectory() + @"\screenshots";

            chrome.Navigate().GoToUrl("http://google.com");

            //Create a new varible 
            Screenshot googleScreenshot = ((ITakesScreenshot)chrome).GetScreenshot();

            //Related to string above. If no directory exists, create. If one does, do not create
            if (Directory.Exists(screenshotDirectory))
            {
                //Create the folder in the directory called "Screenshots" that is currently not there
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + @"\screenshot");
            }           

            //Save the screenshot. Type of file, name of file and location
            //Need to create a unique name for screenshots else you will over ride the file each time
            googleScreenshot.SaveAsFile(Directory.GetCurrentDirectory() + @"\screenshot\googlescreenshot2.jpeg", ScreenshotImageFormat.Jpeg);

            Thread.Sleep(10000);

            chrome.Quit();
        }
    }
}
