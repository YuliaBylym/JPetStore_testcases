using OpenQA.Selenium;

namespace JPetStore_testcases.Locators
{
    class CatsProductPageLocators
    {
        public static By _CatsId { get; set; } = By.XPath("//a[normalize-space()='FL-DSH-01']");
    }
}
