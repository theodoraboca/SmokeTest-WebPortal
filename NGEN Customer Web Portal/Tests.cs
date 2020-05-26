using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using Xunit;

namespace NGEN_Customer_Web_Portal
{
    public class Tests
    {

        [Fact]
        public void LoginTest()
        {
            var driver = new ChromeDriver();
            var wait = new WebDriverWait(driver, new TimeSpan (0,0,5) );

            driver.Navigate().GoToUrl("http://ngen-wp-dev.feelit.iasi.net/login");

            LoginPage Webpage = new LoginPage(driver, wait);

            Webpage.Login("theodora.boca@feel-it-services.com", "NewProject").Logout();

            driver.Close();

            

        }
    }
}
