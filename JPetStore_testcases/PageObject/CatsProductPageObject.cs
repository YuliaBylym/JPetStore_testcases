using OpenQA.Selenium;
using JPetStore_testcases.Locators;

namespace JPetStore_testcases.PageObject
{
    class CatsProductPageObject
    {
        private IWebDriver _webDriver;
        public CatsProductPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }
        public CatProductPageObject SelectProduct()
        {
            _webDriver.FindElement(CatsProductPageLocators._CatsId).Click();
            return new CatProductPageObject(_webDriver);
        }
    }
}
