﻿namespace AutoFramework
{
    using OpenQA.Selenium;
    using NUnit.Framework;
    using System.Threading;
    using AutoTestFramework;
    [Parallelizable]

    public class LoginInvalidPassword
    {
        IAlert alert;
        public IWebDriver Driver { get; set; }

        public LoginInvalidPassword()
        {
        }

        [OneTimeSetUp]
        public void Initialize()
        {
            //This driver will be intialized through the ACTIONS class so it will be done for each test
            Driver = Actions.InitializeDriver();
            NavigateTo.LoginFormScenarioThroughTestCases(Driver);
        }

        [Test]
        public void LessThan5Chars()
        {
            Thread.Sleep(1000);
            Actions.FillLoginForm(Config.Credentials.Valid.Username,
                Config.Credentials.Invalid.Password.FourCharacters,
                Config.Credentials.Invalid.Password.FourCharacters, Driver);
            Thread.Sleep(1000);

            alert = Driver.SwitchTo().Alert();

            //Pause out in to see what is the problem when running two tests
            //The text boxes are not being cleaned out
            Thread.Sleep(5000);
            Assert.AreEqual(Config.AlertsTexts.PasswordLenghtOutOfRange, alert.Text);
            alert.Accept();

        }

        [Test]
        public void MoreThan12Chars()
        {
            Actions.FillLoginForm(Config.Credentials.Valid.Username,
                Config.Credentials.Invalid.Password.ThirteenCharacters, Config.Credentials.Invalid.Password.ThirteenCharacters, Driver);

            alert = Driver.SwitchTo().Alert();
            //Pause out in to see what is the problem when running two tests
            //The text boxes are not being cleaned out
            Thread.Sleep(5000);
            Assert.AreEqual(Config.AlertsTexts.PasswordLenghtOutOfRange, alert.Text);
            alert.Accept();
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.Quit();

        }
    }
}
