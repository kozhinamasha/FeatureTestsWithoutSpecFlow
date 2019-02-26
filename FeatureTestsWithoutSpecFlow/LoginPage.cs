using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace FeatureTestaWithoutSpecFlow
{
    public class LoginPage
    {
        private IWebDriver _driver;

        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
        }

        private By UserName => By.Id("nw_username");
        private By Password => By.Id("nw_password");
        private By SubmitButton => By.Id("nw_submit");

        public void LogIn(string email, string password)
        {
            _driver.FindElement(UserName).SendKeys(email);
            _driver.FindElement(Password).SendKeys(password);
            _driver.FindElement(SubmitButton).Submit();
        }
    }
}
