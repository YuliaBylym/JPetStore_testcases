using OpenQA.Selenium;

namespace JPetStore_testcases.Locators
{
    class LoginMenuLocators
    {
        public static By _username { get; set; } = By.Name("username");
        public static By _password { get; set; } = By.Name("password");
        public static By _loginButton { get; set; } = By.XPath("//input[@name='signon']");
        public static By _signInButton { get; set; } = By.XPath("//a[normalize-space()='Register Now!']");
        public static By _errorMessage { get; set; } = By.XPath("//li[contains(text(),'Invalid username or password.')]");
    }
}
