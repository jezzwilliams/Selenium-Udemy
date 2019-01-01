
namespace AutoTestFramework
{   //Config file is where we store all the test data
    public static class Config
    {
        public static int ElementsWaitingTimeout = 5;
        public static string BaseURL = "http://testing.todvachev.com/";       

        //A new CLASS inside of this class called Credentials
        public static class Credentials
        {
            //A new class for valid credentials for logging
            public static class Valid
            {
                public static string Username = "ValidUser";
                public static string Password = "asdf1234!";
                public static string RepeatPassword = "asdf1234!";
                public static string email = "example@example.com";
            }
            //A new class for invalid credentials for logging
            public static class Invalid
            {
                //Invalid Username data
                public static class Username
                {
                    public static string FourCharacters = "Asdf";
                    public static string ThirteenCharacters = "AsdfAsdfAsdfG";
                }
                //Invalid Password data
                public static class Password
                {
                    public static string NoPassword = "";
                    public static string FourCharacters = "pass";
                    public static string ThirteenCharacters = "AsdfAsdfAsdfG";
                }
                //Invalid email data
                public static class Email
                {
                    public static string InvalidEmail = "eample.gmail.com";
                }
            }
        }

        public static class MenuElements
        {
            public static string Introduction = "Introduction";
            public static string Selectors = "Selectors";
            public static string SpecialElements = "Special Elements";
            public static string TestCases = "Test Cases";
            public static string TestScenarios = "Test Scenarios";
            public static string About = "About";
        }


        public static class AlertMessages
        {
            //Validates the alert message when succssfully logging in to the web form
            public static string SucessfulLogin = "Succesful login!";

        }

        public static class AlertsTexts
        {
            public static string UsernameLengthOutOfRange = "User Id should not be empty / length be between 5 to 12";
            public static string PasswordLenghtOutOfRange = "Password should not be empty / length be between 5 to 12";
            public static string SuccessfulLogin = "Succesful login!";
        }

    }
}
