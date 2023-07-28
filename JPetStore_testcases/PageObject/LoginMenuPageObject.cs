using OpenQA.Selenium;
using System;
using JPetStore_testcases.Data;
using JPetStore_testcases.Locators;

namespace JPetStore_testcases.PageObject
{
    class LoginMenuPageObject
    {
        private IWebDriver _webDriver;
        public LoginMenuPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

    public LoginMenuPageObject LoginFill(string login, string password)
        {
            _webDriver.FindElement(LoginMenuLocators._username).SendKeys(login);

            _webDriver.FindElement(LoginMenuLocators._password).Clear();

            _webDriver.FindElement(LoginMenuLocators._password).SendKeys(password);
            return new LoginMenuPageObject(_webDriver);
        }
    public MainMenuPageObject LoginSuccess()
        {
            _webDriver.FindElement(LoginMenuLocators._loginButton).Click();
            return new MainMenuPageObject(_webDriver);
        }
        public MainMenuPageObject LoginFailed()
        {
            _webDriver.FindElement(LoginMenuLocators._loginButton).Click();
            string errorMessage = _webDriver.FindElement(LoginMenuLocators._errorMessage).Text;        
            
            if (errorMessage.Contains(TestData.ErrorFailedLogin)) {
                return new MainMenuPageObject(_webDriver);
            }
            else
            {
                throw new System.Exception("Login is successful :c");
            }
        }
    public RegistrationMenuPageObject ToSignInForm()
        {
            _webDriver.FindElement(LoginMenuLocators._signInButton).Click();
            return new RegistrationMenuPageObject(_webDriver);
        }
    }

}
