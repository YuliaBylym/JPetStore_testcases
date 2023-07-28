using OpenQA.Selenium;

namespace JPetStore_testcases.Locators
{
    class CatProductLocators
    {
        public static By _itemId { get; set; } = By.XPath("//a[normalize-space()='EST-15']");
    }
}
