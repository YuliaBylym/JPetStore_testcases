using OpenQA.Selenium;
using JPetStore_testcases.Locators;

namespace JPetStore_testcases.PageObject
{
    class RegistrationMenuPageObject
    {
        private IWebDriver _webDriver;
        public RegistrationMenuPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public RegistrationMenuPageObject RegistrationFill(string id, string password, string firstName, string lastName,
            string email, string phone, string adress, string city, string state, string zip, string country)
        {
            _webDriver.FindElement(RegistrationLocators._userId).SendKeys(id);
            _webDriver.FindElement(RegistrationLocators._newPassword).SendKeys(password);
            _webDriver.FindElement(RegistrationLocators._repeatedPassword).SendKeys(password);
            _webDriver.FindElement(RegistrationLocators._firstName).SendKeys(firstName);
            _webDriver.FindElement(RegistrationLocators._lastName).SendKeys(lastName);
            _webDriver.FindElement(RegistrationLocators._email).SendKeys(email);
            _webDriver.FindElement(RegistrationLocators._phone).SendKeys(phone);
            _webDriver.FindElement(RegistrationLocators._address1).SendKeys(adress);
            _webDriver.FindElement(RegistrationLocators._address2).SendKeys(adress);
            _webDriver.FindElement(RegistrationLocators._city).SendKeys(city);
            _webDriver.FindElement(RegistrationLocators._state).SendKeys(state);
            _webDriver.FindElement(RegistrationLocators._zip).SendKeys(zip);
            _webDriver.FindElement(RegistrationLocators._country).SendKeys(country);

            return new RegistrationMenuPageObject(_webDriver);
        }
        public RegistrationMenuPageObject RegistrationFill_Failed(string id, string password)
        {
            _webDriver.FindElement(RegistrationLocators._userId).SendKeys(id);
            _webDriver.FindElement(RegistrationLocators._newPassword).SendKeys(password);

            return new RegistrationMenuPageObject(_webDriver);
        }

        public MainMenuPageObject RegisterButton()
        {
            _webDriver.FindElement(RegistrationLocators._registerButton).Click();
            return new MainMenuPageObject(_webDriver);
        }
    }
}
