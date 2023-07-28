using OpenQA.Selenium;

namespace JPetStore_testcases.Locators
{
    class PaymentPageLocators
    {
        public static By _creditCard { get; set; } = By.Name("order.creditCard");
        public static By _expiryDate { get; set; } = By.Name("order.expiryDate");
        public static By _continueButton { get; set; } = By.Name("newOrder");
    }

}