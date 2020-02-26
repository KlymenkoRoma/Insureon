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
    public class YourGeneralLiabilityDetailsPage : BaseUniAppPage
    {
        private Element protectData(string value) => WebDriver.FindElement(By.XPath($"//div[@id='q-v-34-v-0-v-1-5']/input[@value='{value}']"), $"Protect Data: {value}");
        private Element squareFeetOccupy => WebDriver.FindElement(By.Id("q-v-34-v-0-v-1-11"), "Square Feet Occupy");

        public YourGeneralLiabilityDetailsPage()
        {

        }

        public YourGeneralLiabilityDetailsPage HaveActivePolicies(string value)
        {
            protectData(value).Click();
            return this;
        }

        public YourGeneralLiabilityDetailsPage AddSquareFeetOccupy(string value = null)
        {
            if (value == null)
            {
                squareFeetOccupy.SendKeys("1");
            }
            else squareFeetOccupy.SendKeys(value);

            return this;
        }

        public OptionalCoveragesPage NavigateToOptionalCoveragesPage()
        {
            continueButton.Click();
            return new OptionalCoveragesPage();
        }
    }
}
