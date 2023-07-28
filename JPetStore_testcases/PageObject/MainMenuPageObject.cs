using OpenQA.Selenium;
using JPetStore_testcases.Locators;

namespace JPetStore_testcases.PageObject
{
    class MainMenuPageObject
    {
        private IWebDriver _webDriver;
        public MainMenuPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }
        public LoginMenuPageObject SignInButton()
        {
            _webDriver.FindElement(MainMenuLocators._signInButton).Click();
            return new LoginMenuPageObject(_webDriver);
        }
        public LoginMenuPageObject SignOutButton()
        {
            _webDriver.FindElement(MainMenuLocators._signOutButton).Click();
            return new LoginMenuPageObject(_webDriver);
        }
        public CatsProductPageObject GoToCats()
        {
            _webDriver.FindElement(MainMenuLocators._Cats).Click();
            return new CatsProductPageObject(_webDriver);
        }

        public MainMenuPageObject FillSearchField(string searchText)
        {
            _webDriver.FindElement(MainMenuLocators._searchField).SendKeys(searchText);
            return new MainMenuPageObject(_webDriver);
        }
        
        public SearchPageObject Search()
        {
            _webDriver.FindElement(MainMenuLocators._searchButton).Click();
            return new SearchPageObject(_webDriver);
        }
    }
}
