namespace AutoTestFramework
{
    using OpenQA.Selenium;
    using SeleniumExtras.PageObjects;

    public class LoginScenarioPost
    {
        public LoginScenarioPost(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
        //below are the ELEMENTS we are going to use

        //Finds the User ID Textbox
        [FindsBy(How = How.Name, Using = "userid")]
        //Clicks in the Login User ID Text box
        public IWebElement UsernameField { get; set; }

        //Finds the password Textbox
        [FindsBy(How = How.Name, Using = "passid")]
        //Clicks in the password Text box
        public IWebElement PasswordField { get; set; }

        //Finds the repeat password Textbox
        [FindsBy(How = How.Name, Using = "repeatpassid")]
        //Clicks in the repeat password Text box
        public IWebElement RepeatPasswordField { get; set; }

        //Finds the Login button
        [FindsBy(How = How.Name, Using = "submit")]
        //Clicks on the Login button
        public IWebElement LoginButton { get; set; }

    }
}
