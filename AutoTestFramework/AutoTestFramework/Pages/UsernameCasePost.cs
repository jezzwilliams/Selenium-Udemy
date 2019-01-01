using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AutoTestFramework
{//Username field in login Form
    public class UsernameCasePost
    {
        public UsernameCasePost(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
        //Select the Login Forms hyperlink
        [FindsBy(How = How.CssSelector, Using = "#post-74 > div > p > a")]
        public IWebElement LoginForm { get; set; }
    }
}