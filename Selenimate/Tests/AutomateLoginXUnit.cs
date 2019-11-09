using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using Xunit;

namespace Selenimate.Tests
{
    public class AutomateLoginXUnit
    {
        public string Website { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        [Fact]
        public void TestWithFirefoxDriver()
        {
            using (var driver = new FirefoxDriver(Environment.CurrentDirectory))
            {
                driver.Navigate().GoToUrl(Website);
                //
                var email = driver.FindElement(By.Id("Email"));
                email.SendKeys(Email);
                //
                var password = driver.FindElement(By.Id("Password"));
                password.SendKeys(Password);
                //
                var submitBtn = driver.FindElement(By.ClassName("login-button"));
                submitBtn.Click();
                //
                var foundDropDown = new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(x => { return x.FindElement(By.Id("PriceDDL")) != null; });
                Assert.True(foundDropDown);
            }
        }
        [Fact]
        public void TestWithEdgeDriver()
        {
            using (var driver = new EdgeDriver(Environment.CurrentDirectory))
            {
                driver.Navigate().GoToUrl(Website);
                //
                var email = driver.FindElement(By.Id("Email"));
                email.SendKeys(Email);
                //
                var password = driver.FindElement(By.Id("Password"));
                password.SendKeys(Password);
                //
                var submitBtn = driver.FindElement(By.ClassName("login-button"));
                submitBtn.Click();
                //
                var foundDropDown = new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(x => { return x.FindElement(By.Id("PriceDDL")) != null; });
                Assert.True(foundDropDown);
            }
        }
        [Fact]
        public void TestWithChromeDriver()
        {
            using (var driver = new ChromeDriver(Environment.CurrentDirectory))
            {
                driver.Navigate().GoToUrl(Website);
                //
                var email = driver.FindElement(By.Id("Email"));
                email.SendKeys(Email);
                //
                var password = driver.FindElement(By.Id("Password"));
                password.SendKeys(Password);
                //
                var submitBtn = driver.FindElement(By.ClassName("login-button"));
                submitBtn.Click();
                //
                var foundDropDown = new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(x => { return x.FindElement(By.Id("PriceDDL")) != null; });
                Assert.True(foundDropDown);
            }
        }
    }
}