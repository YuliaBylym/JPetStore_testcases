using OpenQA.Selenium;

namespace JPetStore_testcases.Locators
{
    class SearchLocators
    {
        public static By _productName { get; set; } = By.CssSelector("tbody tr td:nth-child(3)");
    }
}
