using OpenQA.Selenium;

namespace JPetStore_testcases.Locators
{
    class WelcomePageLocators
    {
        public static By _enterButton { get; set; } = By.XPath("//a[normalize-space()='Enter the Store']"); 
    }
}
