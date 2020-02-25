using Insureon.Selenium;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insureon.PageObjects.UniversallAppPages
{
    public class YourInsuranceHistoryPage : BaseUniAppPage
    {
        private IWebElement activePolicies(string value) => WebDriver.FindElement(By.XPath($"//div[@id='q-117']/input[@value='{value}']"));
        private IWebElement reasonNoInsurance(string value) => WebDriver.FindElement(By.XPath($"//div[@id='q-118']/button[text()='{value}']"));
        private IWebElement hasClaims(string value) => WebDriver.FindElement(By.XPath($"//div[@id='q-145']/input[@value='{value}']"));
        private IWebElement claimAgainstCompany(string value) => WebDriver.FindElement(By.XPath($"//div[@id='q-153']/input[@value='{value}']"));

        public YourInsuranceHistoryPage()
        {

        }

        public YourInsuranceHistoryPage HaveActivePolicies(string value)
        {
            activePolicies(value).Click();
            return this;
        }

        public YourInsuranceHistoryPage WhatReasonNoInsurance(string value)
        {
            reasonNoInsurance(value).Click();
            return this;
        }

        public YourInsuranceHistoryPage HasCompanyClaims(string value)
        {
            hasClaims(value).Click();
            return this;
        }

        public YourInsuranceHistoryPage HaveClaimAgainstCompany(string value)
        {
            claimAgainstCompany(value).Click();
            return this;
        }

        public YourGeneralLiabilityDetailsPage NavigateToYourGeneralLiabilityDetailsPage()
        {
            continueButton.Click();
            return new YourGeneralLiabilityDetailsPage();
        }
    }
}
