using Insureon.Selenium;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insureon.PageObjects.UniversallAppPages
{
    public class YourServiceDetailsPage : BaseUniAppPage
    {
        private IWebElement publicCompanyAudit => WebDriver.FindElement(By.Id("q-31"));
        private IWebElement otherAudit => WebDriver.FindElement(By.Id("q-32"));

        public YourServiceDetailsPage()
        {

        }

        public YourServiceDetailsPage AddPublicCompanyAudit(string value = null)
        {
            if (value == null)
            {
                publicCompanyAudit.SendKeys("100");
            }
            else publicCompanyAudit.SendKeys(value);

            return this;
        }

        public YourServiceDetailsPage AddOtherAudit(string value = null)
        {
            if (value == null)
            {
                otherAudit.SendKeys("100");
            }
            else otherAudit.SendKeys(value);

            return this;
        }

        public YourBusinessDetailsPage NavigateToYourBusinessDetailsPage()
        {
            continueButton.Click();
            return new YourBusinessDetailsPage();
        }
    }
}
