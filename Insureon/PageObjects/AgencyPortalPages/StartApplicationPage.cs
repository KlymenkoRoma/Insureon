using Framework.Selenium;
using Insureon.PageObjects.UniversallAppPages;
using Insureon.Selenium;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Insureon.PageObjects.AgencyPortalPages
{
    public class StartApplicationPage
    {
        private Element industry => WebDriver.FindElement(By.XPath("//div[@class='start-app-label']/select[1]"), "Industry dropdown");
        private Element profession => WebDriver.FindElement(By.XPath("//div[@class='start-app-label']/select[2]"), "Profession dropdown");
        private Element continueButton => WebDriver.FindElement(By.XPath("//button[text()='Continue']"), "Continue button");

        public StartApplicationPage()
        {

        }

        public StartApplicationPage GoTo()
        {
            SidebarNav.GoToStartApplicationTab();
            return this;
        }

        public YourCompanyPage NavigateToYourCompanyPage(string ind, string prof)
        {
            WebDriver.Timeout(5);
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
