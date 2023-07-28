using OpenQA.Selenium;
using JPetStore_testcases.Locators;

namespace JPetStore_testcases.PageObject
{
    class ParrotPageObject
    {
        private IWebDriver _webDriver;
        public ParrotPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public ParrotProductPageObject ToProductPage()
        {
            _webDriver.FindElement(ParrotLocators._parrotId).Click(); 
                return new ParrotProductPageObject(_webDriver);
        }
    }
}
