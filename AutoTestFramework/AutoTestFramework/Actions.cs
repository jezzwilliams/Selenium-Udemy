using AutoTestFramework.UIElements;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace AutoTestFramework
{
    public static class Actions
    {
        public static IWebDriver InitializeDriver()
        {
            //Due to parallelization need to create an instance of the driver here
            //Driver.driver = new ChromeDriver();
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl(Config.BaseURL);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            return driver;

            //Driver.WaitForElementUpTo(Config.ElementsWaitingTimeout);
        }

        //method inside actions class that fills our login form
        //below are the ARGUEMENTS we are going to send. They are going to be STRINGS
        public static void FillLoginForm(string username, string password, string repeatPassword, IWebDriver driver)
        {
            //What we need: Username field; Passwork field; Repeat password field; Login button
            //inspect all these elements

            LoginScenarioPost lsPost = new LoginScenarioPost(driver);

            lsPost.UsernameField.Clear();//Clear the text boxes BEFORE writing anything into it
            lsPost.UsernameField.SendKeys(username);
            lsPost.PasswordField.Clear();//Clear the text boxes BEFORE writing anything into it
            lsPost.PasswordField.SendKeys(password);
            lsPost.RepeatPasswordField.Clear();//Clear the text boxes BEFORE writing anything into it
            lsPost.RepeatPasswordField.SendKeys(repeatPassword);
            lsPost.LoginButton.Click();

        }
    }
}
