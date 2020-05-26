using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Security.Cryptography.X509Certificates;

namespace NGEN_Customer_Web_Portal
{
    public class HomePage
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;

        public HomePage(IWebDriver driver, WebDriverWait wait)
        {
            _driver = driver;
            _wait = wait;
        }

        public IWebElement LogoutButton => _driver.FindElement(By.CssSelector("button.btn"));
        
        public LoginPage Logout()
        {
           
            LogoutButton.Click();

            var yesConfirmationButton = _driver.FindElement(By.CssSelector(".btn.btn-sm.btn-primary.d-flex.align-items-center.pl-5.pr-5"));
            yesConfirmationButton.Click();

            return new LoginPage(_driver, _wait);

        }
    }
}