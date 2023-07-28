using OpenQA.Selenium;
using JPetStore_testcases.Locators;

namespace JPetStore_testcases.PageObject
{
    class ConfirmOrdertPageObject
    {
        private IWebDriver _webDriver;
        public ConfirmOrdertPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }
        public OrderDetailsPageObject ConfirmCheckout()
        {
            _webDriver.FindElement(ConfirmOrderPageLocators._confirmOrderButton).Click();
            return new OrderDetailsPageObject(_webDriver);
        }
    }
    
}
