using Insureon.PageObjects.UniversallAppPages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Insureon.Selenium;
using Framework.Selenium;

namespace Insureon.PageObjects.BasePages
{
    public class HomePage
    {
        private Element startApplication => WebDriver.FindElement(By.CssSelector("a[href='/start-application']"), "Start Application tab");
        private Element industry => WebDriver.FindElement(By.XPath("//div[@class='start-app-label']/select[1]"), "Industry dropdown");
        private Element profession => WebDriver.FindElement(By.XPath("//div[@class='start-app-label']/select[2]"), "Profession dropdown");
        private Element continueButton => WebDriver.FindElement(By.XPath("//button[text()='Continue']"), "Continue button");

        public HomePage()
        {

        }

        public YourCompanyPage NavigateToYourCompanyPage(string ind, string prof)
        {
            WebDriver.Timeout(5);
            startApplication.Click();
            SetSomeValueFromDropDown(industry, ind);
            SetSomeValueFromDropDown(profession, prof);
            continueButton.Click();
            return new YourCompanyPage();
        }

        private void SetSomeValueFromDropDown(IWebElement dropdown, string information)
        {
            SelectElement testElement = new SelectElement(dropdown);
            testElement.SelectByText(information);
        }
    }
}
