using OpenQA.Selenium;
using JPetStore_testcases.Locators;

namespace JPetStore_testcases.PageObject
{
    class ParrotProductPageObject
    {
        private IWebDriver _webDriver;
        public ParrotProductPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public CartPageObject ToCart()
        {
            _webDriver.FindElement(ParrotProductLocators._toCartButton).Click();
            return new CartPageObject(_webDriver);
        }
    }
}
