using OpenQA.Selenium;
using JPetStore_testcases.Locators;

namespace JPetStore_testcases.PageObject
{
    class CartPageObject
    {
        private IWebDriver _webDriver;
        public CartPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }
        public PaymentPageObject ProccedToCheckout()
        {
            _webDriver.FindElement(CartPageLocators._proceedToCheckoutButton).Click();
            return new PaymentPageObject(_webDriver);
        }
        public ParrotsPageObject GoToParrots()
        {
            _webDriver.FindElement(CartPageLocators._goToParrots).Click();
            return new ParrotsPageObject(_webDriver);
        }
        public CartPageObject ChangeQuantity(string qauntity)
        {
            _webDriver.FindElement(CartPageLocators._quantityField).Clear();
            _webDriver.FindElement(CartPageLocators._quantityField).SendKeys(qauntity);
            
            return new CartPageObject(_webDriver);
        }        
        public CartPageObject UpdateCart()
        {
            _webDriver.FindElement(CartPageLocators._updateCartButton).Click();
            
            return new CartPageObject(_webDriver);
        }
    }
}
