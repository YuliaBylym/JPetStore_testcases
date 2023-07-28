using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using JPetStore_testcases.Data;
using JPetStore_testcases.PageObject;

namespace JPetStore_testcases
{
    public class PositiveTests
    {
        private IWebDriver _webDriver;
        private readonly string _url = "https://petstore.octoperf.com/";
        public bool CheckAnything(string any) =>
            _webDriver.PageSource.Contains(any);

        [OneTimeSetUp]
        public void Setup()
        {
            _webDriver = new ChromeDriver(Environment.CurrentDirectory);

            _webDriver.Navigate().GoToUrl(_url);
        }
        [Test]
        public void Login()
        {
            WelcomePageObject login = new WelcomePageObject(_webDriver);
            login
                .EnterShop()
                .SignInButton()
                .LoginFill(TestData.Login, TestData.Password)
                .LoginSuccess();

            Assert.True(CheckAnything(TestData.LoginSuccess));
        }
        [Test]
        public void SignOut()
        {
            WelcomePageObject login = new WelcomePageObject(_webDriver);
            login
                .EnterShop()
                .SignInButton()
                .LoginFill(TestData.Login, TestData.Password)
                .LoginSuccess()
                .SignOutButton();

            Assert.True(CheckAnything(TestData.SignOutSuccess));
        }
        [Test]
        public void Registration()
        {
            WelcomePageObject reg = new WelcomePageObject(_webDriver);
            reg
                .EnterShop()
                .SignInButton()
                .ToSignInForm()
                .RegistrationFill(TestData.RandomUserId, TestData.RandomPassword, TestData.FirstName, TestData.LastName, TestData.Email,
                                  TestData.Phone, TestData.Address, TestData.City, TestData.State, TestData.Zip, TestData.Country)
                .RegisterButton();

            Assert.True(CheckAnything(TestData.RegisterSuccess));

        }
        [Test]
        public void AccountDataChange()
        {
            WelcomePageObject reg = new WelcomePageObject(_webDriver);
            reg
                .EnterShop()
                .SignInButton()
                .LoginFill(TestData.Login, TestData.Password)
                .LoginSuccess()
                .ToAccountPage()
                .ChangeAccountInfo(TestData.UserFirstName, TestData.UserLastName)
                .SaveNewAccountInfo()
                .ToMainMenu()
                .ToAccountPage();

            Assert.True(CheckAnything(TestData.UserFirstName));
            Assert.True(CheckAnything(TestData.UserLastName));
        }
        
        [Test]
        public void CheckoutProduct()
        {
            WelcomePageObject checkout = new WelcomePageObject(_webDriver);
            checkout
                .EnterShop()
                .SignInButton()
                .LoginFill(TestData.Login, TestData.Password)
                .LoginSuccess()
                .GoToCats()
                .SelectProduct()
                .OpenProductPage()
                .AddToCart()
                .ProccedToCheckout()
                .FillPaymentDetails(TestData.creditCard, TestData.expiryDate)
                .ConfirmPaymentDetails()
                .ConfirmCheckout();

            Assert.True(CheckAnything(TestData.CheckoutSuccess));
        }

        [Test]
        public void CheckouTwoDifferentProducts()
        {
            WelcomePageObject checkoutFew = new WelcomePageObject(_webDriver);
            checkoutFew
                .EnterShop()
                .SignInButton()
                .LoginFill(TestData.Login, TestData.Password)
                .LoginSuccess()
                .GoToCats()
                .SelectProduct()
                .OpenProductPage()
                .AddToCart()
                .GoToParrots()
                .SelectParrot()
                .ToProductPage()
                .ToCart()
                .ProccedToCheckout()
                .FillPaymentDetails(TestData.creditCard, TestData.expiryDate)
                .ConfirmPaymentDetails()
                .ConfirmCheckout();

            Assert.True(CheckAnything(TestData.CheckoutSuccess));
        }

        [Test]
        public void CheckoutFewOfTheSameProduct()
        {
            WelcomePageObject checkout = new WelcomePageObject(_webDriver);
            checkout
                .EnterShop()
                .SignInButton()
                .LoginFill(TestData.Login, TestData.Password)
                .LoginSuccess()
                .GoToCats()
                .SelectProduct()
                .OpenProductPage()
                .AddToCart()
                .ChangeQuantity(TestData.Quantity)
                .UpdateCart()
                .ProccedToCheckout()
                .FillPaymentDetails(TestData.creditCard, TestData.expiryDate)
                .ConfirmPaymentDetails()
                .ConfirmCheckout();

            Assert.True(CheckAnything(TestData.CheckoutSuccess));
        }

        [Test]
        public void Searching()
        {
            WelcomePageObject search = new WelcomePageObject(_webDriver);
            search
                .EnterShop()
                .FillSearchField(TestData.SearchText)
                .Search()
                .SearchSuccess();
        }

        [TearDown]
        public void EndTest()
        {
            if (CheckAnything(TestData.LoginSuccess) == true)
            {
                MainMenuPageObject main = new MainMenuPageObject(_webDriver);
                main.SignOutButton();
            }

            _webDriver.Navigate().GoToUrl(_url);
        }
    }
    public class NegativeTests
    {
        private IWebDriver _webDriver;
        private readonly string _url = "https://petstore.octoperf.com/";
        public bool CheckAnything(string any) =>
            _webDriver.PageSource.Contains(any);

        [OneTimeSetUp]
        public void Setup()
        {
            _webDriver = new ChromeDriver(Environment.CurrentDirectory);

            _webDriver.Navigate().GoToUrl(_url);
        }

        [Test]
        public void FailedLogin()
        {
            WelcomePageObject login = new WelcomePageObject(_webDriver);
            login
                .EnterShop()
                .SignInButton()
                .LoginFill(TestData.Login, TestData.IncorrectPassword)
                .LoginFailed();
        }
        [Test]
        public void FailedRegistration()
        {
            WelcomePageObject failedReg = new WelcomePageObject(_webDriver);
            failedReg

                .EnterShop()
                .SignInButton()
                .ToSignInForm()
                .RegistrationFill_Failed(TestData.RandomUserId, TestData.RandomPassword)
                .RegisterButton();

            Assert.True(CheckAnything(TestData.ErrorFailedRegistation));
        }
        [Test]
        public void FailedCheckout()
        {

            WelcomePageObject failedCheckout = new WelcomePageObject(_webDriver);
            failedCheckout

                .EnterShop()
                .SignInButton()
                .LoginFill(TestData.Login, TestData.Password)
                .LoginSuccess()
                .GoToCats()
                .SelectProduct()
                .OpenProductPage()
                .AddToCart()
                .ProccedToCheckout()
                .FillPaymentDetails_Failed(TestData.creditCard, TestData.expiryDate)
                .ConfirmPaymentDetails()
                .ConfirmCheckout();

            Assert.True(CheckAnything(TestData.ErrorFailedCheckout));

        }

        [TearDown]
        public void EndTest()
        {
            if (CheckAnything(TestData.LoginSuccess) == true)
            {
                MainMenuPageObject main = new MainMenuPageObject(_webDriver);
                main.SignOutButton();
            }

            _webDriver.Navigate().GoToUrl(_url);
        }
    }
}
    

