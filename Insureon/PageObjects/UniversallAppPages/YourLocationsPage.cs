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
    public class YourLocationsPage : BaseUniAppPage
    {
        private Element homeBased(string value) => WebDriver.FindElement(By.XPath($"//div[@id='q-v-13-0']/input[@value='{value}']"), $"Home Based: {value}");
        private Element addressLine1 => WebDriver.FindElement(By.Id("v-13-3"), "Address Line1");

        public YourLocationsPage()
        {

        }

        public YourLocationsPage SelectBusinessBased(string value)
        {
            homeBased(value).Click();
            return this;
        }

        public YourLocationsPage AddAddressLine1(string value = null)
        {
            if (value == null)
            {
                addressLine1.SendKeys(new Bogus.DataSets.Address().StreetAddress());
            }
            else addressLine1.SendKeys(value);

            return this;
        }

        public YourServiceDetailsPage NavigateToYourServiceDetailsPage()
        {
            continueButton.Click();
            return new YourServiceDetailsPage();
        }
    }
}
