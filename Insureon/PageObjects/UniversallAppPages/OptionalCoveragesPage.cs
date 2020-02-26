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
    public class OptionalCoveragesPage : BaseUniAppPage
    {
        private Element employmentPracticesLiability(string value) => WebDriver.FindElement(By.XPath($"//div[@id='q-165']/input[@value='{value}']"), $"Employment Practices Liability: {value}");
        private Element dataBreach(string value) => WebDriver.FindElement(By.XPath($"//div[@id='q-183']/input[@value='{value}']"), $"Data Breach: {value}");
        private Element cyberSuiteType(string value) => WebDriver.FindElement(By.XPath($"//div[@id='q-186']/button[text()='{value}']"), $"Cyber Suite Type: {value}");
        private Element cyberSuiteLimit(string value) => WebDriver.FindElement(By.XPath($"//div[@id='q-187']/button[text()='{value}']"), $"Cyber Suite Limit: {value}");
        private Element professionalLiability(string value) => WebDriver.FindElement(By.XPath($"//div[@id='q-210']/button[text()='{value}']"), $"Professional Liability: {value}");
        private Element businessVehicles(string value) => WebDriver.FindElement(By.XPath($"//div[@id='q-218']/input[@value='{value}']"), $"Business Vehicles: {value}");
        private Element quoteCommercialAuto(string value) => WebDriver.FindElement(By.XPath($"//div[@id='q-219']/input[@value='{value}']"), $"Quote Commercial Auto: {value}");
        private Element additionalInsured(string value) => WebDriver.FindElement(By.XPath($"//div[@id='q-239']/input[@value='{value}']"), $"Additional Insured: {value}");

        public OptionalCoveragesPage()
        {

        }

        public OptionalCoveragesPage WantEmploymentPracticesLiability(string value)
        {
            employmentPracticesLiability(value).Click();
            return this;
        }

        public OptionalCoveragesPage WantDataBreach(string value)
        {
            dataBreach(value).Click();
            return this;
        }

        public OptionalCoveragesPage WhatCyberSuiteType(string value)
        {
            cyberSuiteType(value).Click();
            return this;
        }

        public OptionalCoveragesPage WhatCyberSuiteLimit(string value)
        {
            cyberSuiteLimit(value).Click();
            return this;
        }

        public OptionalCoveragesPage SelectProfessionalLiability(string value)
        {
            professionalLiability(value).Click();
            return this;
        }

        public OptionalCoveragesPage HaveBusinessVehicles(string value)
        {
            businessVehicles(value).Click();
            return this;
        }

        public OptionalCoveragesPage WantQuoteCommercialAuto(string value)
        {
            quoteCommercialAuto(value).Click();
            return this;
        }

        public OptionalCoveragesPage WantAdditionalInsured(string value)
        {
            WebDriver.WebActions().MoveToElement(certificateFooter).Perform();
            additionalInsured(value).Click();
            return this;
        }

        public OptionalDiscountsPage NavigateToOptionalDiscountsPage()
        {
            continueButton.Click();
            return new OptionalDiscountsPage();
        }
    }
}
