using Framework.Selenium;
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
        private Element activePolicies(string value) => WebDriver.FindElement(By.XPath($"//div[@id='q-117']/input[@value='{value}']"), $"Active Policies: {value}");
        private Element reasonNoInsurance(string value) => WebDriver.FindElement(By.XPath($"//div[@id='q-118']/button[text()='{value}']"), $"Reason No Insurance: {value}");
        private Element hasClaims(string value) => WebDriver.FindElement(By.XPath($"//div[@id='q-145']/input[@value='{value}']"), $"Has Claims: {value}");
        private Element claimAgainstCompany(string value) => WebDriver.FindElement(By.XPath($"//div[@id='q-153']/input[@value='{value}']"), $"Claim Against Company: {value}");

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
