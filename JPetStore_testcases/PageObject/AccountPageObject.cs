using OpenQA.Selenium;
using JPetStore_testcases.Locators;

namespace JPetStore_testcases.PageObject
{
    class AccountPageObject
    {
        private IWebDriver _webDriver;
        public AccountPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }
        public AccountPageObject ChangeAccountInfo(string userFirstName, string userLastName)
        {
            _webDriver.FindElement(AccountPageLocators._userFirstName).Clear();
            _webDriver.FindElement(AccountPageLocators._userFirstName).SendKeys(userFirstName);
            _webDriver.FindElement(AccountPageLocators._userLastName).Clear();
            _webDriver.FindElement(AccountPageLocators._userLastName).SendKeys(userLastName);
            return new AccountPageObject(_webDriver);
        }
        public AccountPageObject SaveNewAccountInfo()
        {
            _webDriver.FindElement(AccountPageLocators._saveAccountInfoButton).Click();
            return new AccountPageObject(_webDriver);
        }
        public MainMenuPageObject ToMainMenu()
        {
            _webDriver.FindElement(AccountPageLocators._JPetLogoButton).Click();
            return new MainMenuPageObject(_webDriver);
        }

    }
}
