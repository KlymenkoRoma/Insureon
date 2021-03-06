﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Framework;
using Framework.Selenium;
using Insureon.PageObjects.AgencyPortalPages;
using Insureon.Selenium;
using OpenQA.Selenium;

namespace Insureon.PageObjects.BasePages
{
    public class AgentLoginPage
    {
        private Element emailField => WebDriver.FindElement(By.Id("emailAddress"), "Email Address");
        private Element passwordField => WebDriver.FindElement(By.Id("password"), "Password");
        private Element logInButton => WebDriver.FindElement(By.Id("LogIn"), "LogIn button");

        public AgentLoginPage()
        {

        }

        public HomePage Login()
        {
            string login = FrameWork.Config.Test.Login;
            string password = FrameWork.Config.Test.Password;

            Thread.Sleep(1000);
            emailField.SendKeys(login);
            Thread.Sleep(1000);
            passwordField.SendKeys(password);

            logInButton.Click();

            return new HomePage();
        }
    }
}
