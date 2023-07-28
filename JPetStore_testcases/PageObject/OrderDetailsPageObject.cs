using OpenQA.Selenium;
using JPetStore_testcases.Locators;

namespace JPetStore_testcases.PageObject
{
    class OrderDetailsPageObject
    {
        private IWebDriver _webDriver;
        public OrderDetailsPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }
        public MainMenuPageObject BackToMainMenu()
        {
            _webDriver.FindElement(OrderDetailsLocators._backToMainButton).Click();
            return new MainMenuPageObject(_webDriver);
        }
    }
}
