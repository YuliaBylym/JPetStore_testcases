using OpenQA.Selenium;

namespace JPetStore_testcases.Locators
{
    class ParrotLocators
    {
        public static By _parrotId { get; set; } = By.XPath("//a[normalize-space()='EST-19']");
    }
}
