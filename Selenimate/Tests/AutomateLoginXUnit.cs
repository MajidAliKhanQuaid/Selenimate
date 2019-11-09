
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using Xunit;

namespace Selenimate.Tests
{
    public class AutomateLoginXUnit
    {
        public string Website { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        //[Fact]
        //public void TestWithFirefoxDriver()
        //{
        //    using (var driver = new FirefoxDriver())
        //    {
        //        driver.Navigate().GoToUrl(Website);
        //        //
        //        var email = driver.FindElement(By.Id("Email"));
        //        email.SendKeys(Email);
        //        //
        //        var password = driver.FindElement(By.Id("Password"));
        //        password.SendKeys(Password);
        //        //
        //        var submitBtn = driver.FindElement(By.ClassName("login-button"));
        //        submitBtn.Click();
        //    }
        //}
        [Fact]
        public void TestWithEdgeDriver()
        {
            using (var driver = new EdgeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)))
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
            }
        }
        [Fact]
        public void TestWithChromeDriver()
        {
            using (var driver = new ChromeDriver())
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
            }
        }
    }
}