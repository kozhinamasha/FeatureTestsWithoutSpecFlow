using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace FeatureTestaWithoutSpecFlow
{
    public class HomePage
    {
        private IWebDriver _driver;
        public HomePage(IWebDriver driver)
        {
            _driver = driver;
        }

        private By SignInButton => By.Id("log_in");

        public string GetPageTitle()
        {
            _driver.Navigate().GoToUrl("https://hub.docker.com/");
            string title = _driver.Title;
            return title;
        }

        public void GoToLoginPage()
        {
            _driver.FindElement(SignInButton).Click();
        }
    }
}
