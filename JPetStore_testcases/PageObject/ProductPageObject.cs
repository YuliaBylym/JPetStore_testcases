using OpenQA.Selenium;
using JPetStore_testcases.Locators;

namespace JPetStore_testcases.PageObject
{
    class ProductPageObject
    {
        private IWebDriver _webDriver;
        public ProductPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }
        public CartPageObject AddToCart()
        {
            _webDriver.FindElement(ProductPageLocators._addToCartButton).Click();
            return new CartPageObject(_webDriver);
        }
    }
}
