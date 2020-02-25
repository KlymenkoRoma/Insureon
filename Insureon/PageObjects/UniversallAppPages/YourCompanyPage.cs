using Bogus;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Insureon.Selenium;
using Framework.Selenium;

namespace Insureon.PageObjects.UniversallAppPages
{
    public class YourCompanyPage : BaseUniAppPage
    {
        private Element zipCode => WebDriver.FindElement(By.XPath("//label[text()='What is the zip code of your primary business location?']//following-sibling::input"), "zip Code");
        private Element bissName => WebDriver.FindElement(By.Id("v-1-2"), "Bissness Name");

        [ThreadStatic] 
        public static string clientName;

        public YourCompanyPage()
        {

        }

        public YourCompanyPage AddZipCode(string value = null)
        {
            if (value == null)
            {
                zipCode.SendKeys("60606");
            }
            else zipCode.SendKeys(value);

            return this;
        }

        public YourCompanyPage AddBissnessName(string value = null)
        {
            if (value == null)
            {
                clientName = bissnessName;
                bissName.SendKeys(clientName);
            }
            else
            {
                bissName.SendKeys(value);
                clientName = value;
            }

            return this;
        }

        public YourProtectionPage NavigateToYourProtectionPage()
        {
            continueButton.Click();
            return new YourProtectionPage();
        }
    }
}
