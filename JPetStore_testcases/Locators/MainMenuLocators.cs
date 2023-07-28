using OpenQA.Selenium;

namespace JPetStore_testcases.Locators
{
    class MainMenuLocators
    {
        public static By _signInButton { get; set; } = By.XPath("//a[normalize-space()='Sign In']");
        public static By _signOutButton { get; set; } = By.XPath("//a[normalize-space()='Sign Out']");
        public static By _Cats { get; set; } = By.XPath("//area[@alt='Cats']");
        public static By _searchField { get; set; } = By.XPath("//input[@name='keyword']");
        public static By _searchButton { get; set; } = By.XPath("//input[@name='searchProducts']");
        public static By _accountButton { get; set; } = By.XPath("//a[normalize-space()='My Account']");

    }
}
