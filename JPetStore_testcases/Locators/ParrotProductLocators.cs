using OpenQA.Selenium;

namespace JPetStore_testcases.Locators
{
    class ParrotProductLocators
    {
        public static By _toCartButton { get; set; } = By.XPath("//a[@class='Button']");
    }
}
