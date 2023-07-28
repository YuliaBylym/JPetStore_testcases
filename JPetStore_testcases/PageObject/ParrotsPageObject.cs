using OpenQA.Selenium;
using JPetStore_testcases.Locators;

namespace JPetStore_testcases.PageObject
{
    class ParrotsPageObject
    {
        private IWebDriver _webDriver;
        public ParrotsPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }
        public ParrotPageObject SelectParrot()
        {
            _webDriver.FindElement(ParrotsLocators._toBreed).Click();
            return new ParrotPageObject(_webDriver);
        }

    }
}
