using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace NGEN_Customer_Web_Portal
{
    public class LoginPage
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;

        public LoginPage(IWebDriver driver, WebDriverWait wait)
        {
            _driver = driver;
            _wait = wait;

        }

        public IWebElement Email => _driver.FindElement(By.XPath("//input[@type='email']"));
        public IWebElement Password => _driver.FindElement(By.XPath("//input[@type='password']"));

        public HomePage Login(string email, string password)
        {
            var loginButton = _driver.FindElement(By.XPath("//button[@type='button']"));
            Email.SendKeys(email);
            Password.SendKeys(password);
            loginButton.Click();
            return new HomePage(_driver, _wait);
        }






    }
}
