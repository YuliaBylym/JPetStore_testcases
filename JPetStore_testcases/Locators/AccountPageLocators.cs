using OpenQA.Selenium;

namespace JPetStore_testcases.Locators
{
    class AccountPageLocators
    {
        public static By _userFirstName = By.XPath("//input[@name='account.firstName']");
        public static By _userLastName = By.XPath("//input[@name='account.lastName']");
        public static By _saveAccountInfoButton = By.XPath("//input[@name='editAccount']");
        public static By _JPetLogoButton = By.XPath("//img[@src='../images/logo-topbar.gif']");
    }
}
