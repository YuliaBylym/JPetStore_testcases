using OpenQA.Selenium;
using JPetStore_testcases.Locators;

namespace JPetStore_testcases.PageObject
{
    class CatProductPageObject
    {
        private IWebDriver _webDriver;
        public CatProductPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }
        public ProductPageObject OpenProductPage()
        {
            _webDriver.FindElement(CatProductLocators._itemId).Click();
            return new ProductPageObject(_webDriver);
        }

    }
}
