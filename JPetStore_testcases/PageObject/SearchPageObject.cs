using System;
using OpenQA.Selenium;
using JPetStore_testcases.Locators;
using JPetStore_testcases.Data;

namespace JPetStore_testcases.PageObject
{
    class SearchPageObject
    {
        private IWebDriver _webDriver;
        public SearchPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }
        
        public SearchPageObject SearchSuccess()
        {
            string textToSearch = TestData.SearchText;
            string product_name = _webDriver.FindElement(SearchLocators._productName).Text;
            if (product_name.Contains(textToSearch))
            {
                return new SearchPageObject(_webDriver);
            }
            else
            {
                throw new System.Exception("Search is not matching");
            }
        }
    }
}
