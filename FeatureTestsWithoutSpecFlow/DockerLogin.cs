using System;
using System.ComponentModel;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace FeatureTestaWithoutSpecFlow
{
    [TestClass]
    public class DockerLogin
    {
       
        private IWebDriver _driver;

        [SetUp]
        public void BrowserConfig()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize(); 
        }

        [TestMethod]
        public void Docker()
        {
            _driver = new ChromeDriver();
            HomePage home = new HomePage(_driver);
            home.GetPageTitle().Should().Be("Docker Hub");
            home.GoToLoginPage();
            LoginPage login = new LoginPage(_driver);
            login.LogIn("kozhynamasha", "Kykolka1987");
        }

        [TearDown]
        public void Quit()
        {
            _driver.Quit();
        }

    }
}
