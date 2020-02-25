using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework;
using Framework.Selenium;
using Insureon.Selenium;
using OpenQA.Selenium;

namespace Insureon.PageObjects.BasePages
{
    public class AgentLoginPage
    {
        private Element emailField => WebDriver.FindElement(By.Id("emailAddress"), "Email field");
        private Element passwordField => WebDriver.FindElement(By.Id("password"), "Password field");
        private Element logInButton => WebDriver.FindElement(By.Id("LogIn"), "LogIn button");

        public AgentLoginPage()
        {

        }

        public HomePage Login()
        {
            string login = FrameWork.Config.Test.Login;
            string password = FrameWork.Config.Test.Password;

            emailField.SendKeys(login);
            WebDriver.Timeout(25);
            passwordField.SendKeys(password);

            logInButton.Click();

            return new HomePage();
        }
    }
}
