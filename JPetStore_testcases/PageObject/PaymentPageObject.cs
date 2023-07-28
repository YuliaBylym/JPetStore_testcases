using OpenQA.Selenium;
using JPetStore_testcases.Locators;

namespace JPetStore_testcases.PageObject
{
    class PaymentPageObject
    {
        private IWebDriver _webDriver;
        public PaymentPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }
        public PaymentPageObject FillPaymentDetails(string creditCard, string expiryDate)
        {

            _webDriver.FindElement(PaymentPageLocators._creditCard).Clear(); 
            _webDriver.FindElement(PaymentPageLocators._creditCard).SendKeys(creditCard);
            _webDriver.FindElement(PaymentPageLocators._expiryDate).Clear(); 
            _webDriver.FindElement(PaymentPageLocators._expiryDate).SendKeys(expiryDate);

            return new PaymentPageObject(_webDriver);
        } 
        public PaymentPageObject FillPaymentDetails_Failed(string creditCard, string expiryDate)
        {

            _webDriver.FindElement(PaymentPageLocators._creditCard).Clear(); 
            _webDriver.FindElement(PaymentPageLocators._expiryDate).Clear(); 

            return new PaymentPageObject(_webDriver);
        }     
        public ConfirmOrdertPageObject ConfirmPaymentDetails()
        {
            _webDriver.FindElement(PaymentPageLocators._continueButton).Click();
            return new ConfirmOrdertPageObject(_webDriver);
        }
    }
}
