using OpenQA.Selenium;

namespace AutoTestFramework
{
    public static class NavigateTo
    {
        public static void LoginFormScenarioThroughTestCases(IWebDriver driver)
        {//Login through the Test Cases Page


            Menu menu = new Menu(driver);
            TestCasesPage tcPage = new TestCasesPage(driver);
            UsernameCasePost ucPost = new UsernameCasePost(driver);

            menu.TestCases.Click();
            tcPage.UsernameCase.Click();
            ucPost.LoginForm.Click();
        }

        public static void LoginFormScenarioThroughMenu(IWebDriver driver)
        {
            //Need to click through the menu and the Test Scenarios page

            //Initialize the Menu through this method
            Menu menu = new Menu(driver);

            //Initialize the Test Scneaios page
            TestScenariosPage tsPage = new TestScenariosPage(driver);

            //After loading the Homepage, need to click on the menu
            menu.TestScenarios.Click();
            //Then click on the LoginForm
            tsPage.LoginForm.Click();
        }
       

       
    }
}
