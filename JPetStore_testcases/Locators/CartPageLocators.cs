using OpenQA.Selenium;

namespace JPetStore_testcases.Locators
{
    class CartPageLocators
    {
        public static By _proceedToCheckoutButton { get; set; } = By.XPath("//a[normalize-space()='Proceed to Checkout']");
        public static By _goToParrots { get; set; } = By.XPath("//img[@src='../images/sm_birds.gif']");
        public static By _quantityField { get; set; } = By.CssSelector("input[value='1']");
        public static By _updateCartButton { get; set; } = By.XPath("//input[@name='updateCartQuantities']");

    }
}
