using Insureon.Selenium;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insureon.PageObjects.UniversallAppPages
{
    public class YourBusinessDetailsPage : BaseUniAppPage
    {
        private IWebElement describeBusiness => WebDriver.FindElement(By.Id("q-61"));
        private IWebElement website(string value) => WebDriver.FindElement(By.XPath($"//div[@id='q-62']/input[@value='{value}']"));
        private IWebElement useAgreement(string value) => WebDriver.FindElement(By.XPath($"//div[@id='q-68']/button[text()='{value}']"));
        private IWebElement useDeclinationLetters(string value) => WebDriver.FindElement(By.XPath($"//div[@id='q-71']/input[@value='{value}']"));
        private IWebElement businessConsult(string value) => WebDriver.FindElement(By.XPath($"//div[@id='q-73']/input[@value='{value}']"));
        private IWebElement tangibleGoods(string value) => WebDriver.FindElement(By.XPath($"//div[@id='q-74']/input[@value='{value}']"));
        private IWebElement performDesign(string value) => WebDriver.FindElement(By.XPath($"//div[@id='q-77']/input[@value='{value}']"));
        private IWebElement partTime(string value) => WebDriver.FindElement(By.XPath($"//div[@id='q-79']/input[@value='{value}']"));
        private IWebElement taxLiensBankruptcy(string value) => WebDriver.FindElement(By.XPath($"//div[@id='q-80']/input[@value='{value}']"));
        private IWebElement subsidiaries(string value) => WebDriver.FindElement(By.XPath($"//div[@id='q-82']/input[@value='{value}']"));
        private IWebElement crimeFraud(string value) => WebDriver.FindElement(By.XPath($"//div[@id='q-83']/input[@value='{value}']"));
        private IWebElement ownHalf(string value) => WebDriver.FindElement(By.XPath($"//div[@id='q-84']/input[@value='{value}']"));
        private IWebElement ownerFirmNone => WebDriver.FindElement(By.XPath("//label[text()='Had their license revoked or suspended']"));
        private IWebElement staffFirmNone => WebDriver.FindElement(By.XPath("//label[text()='Provided services to any publicly held client']"));
        private IWebElement staffFirmNoneDetails => WebDriver.FindElement(By.Id("q-97"));
        private IWebElement suedClient(string value) => WebDriver.FindElement(By.XPath($"//div[@id='q-98']/input[@value='{value}']"));
        private IWebElement revenueNextYear => WebDriver.FindElement(By.XPath("//label[text()='What will your revenue be for the next fiscal year?']//following-sibling::input"));
        private IWebElement revenueCurrentYear => WebDriver.FindElement(By.XPath("//label[text()='What is your revenue for the current fiscal year?']//following-sibling::input"));
        private IWebElement revenuePriorYear => WebDriver.FindElement(By.XPath("//label[text()='What was your revenue in the prior fiscal year?']//following-sibling::input"));

        public YourBusinessDetailsPage()
        {

        }

        public YourBusinessDetailsPage AddDescribeBusiness(string value = null)
        {
            if (value == null)
            {
                describeBusiness.SendKeys("TestData");
            }
            else describeBusiness.SendKeys(value);

            return this;
        }

        public YourBusinessDetailsPage HaveWebsite(string value)
        {
            website(value).Click();
            return this;
        }

        public YourBusinessDetailsPage DoUseAgreement(string value)
        {
            useAgreement(value).Click();
            return this;
        }

        public YourBusinessDetailsPage DoUseDeclinationLetters(string value)
        {
            useDeclinationLetters(value).Click();
            return this;
        }

        public YourBusinessDetailsPage DoBusinessConsult(string value)
        {
            businessConsult(value).Click();
            return this;
        }

        public YourBusinessDetailsPage DoTangibleGoods(string value)
        {
            WebDriver.WebActions().MoveToElement(ownerFirmNone).Perform();
            tangibleGoods(value).Click();
            return this;
        }

        public YourBusinessDetailsPage DoPerformDesign(string value)
        {
            performDesign(value).Click();
            return this;
        }

        public YourBusinessDetailsPage DoPartTime(string value)
        {
            partTime(value).Click();
            return this;
        }

        public YourBusinessDetailsPage DoTaxLiensBankruptcy(string value)
        {
            taxLiensBankruptcy(value).Click();
            return this;
        }

        public YourBusinessDetailsPage DoSubsidiaries(string value)
        {
            subsidiaries(value).Click();
            return this;
        }

        public YourBusinessDetailsPage DoCrimeFraud(string value)
        {
            crimeFraud(value).Click();
            return this;
        }

        public YourBusinessDetailsPage DoOwnHalf(string value)
        {
            ownHalf(value).Click();
            return this;
        }

        public YourBusinessDetailsPage DoOwnerFirmNone()
        {
            WebDriver.WebActions().MoveToElement(suedClient("No")).Perform();
            ownerFirmNone.Click();
            return this;
        }

        public YourBusinessDetailsPage DoStaffFirmNone()
        {
            staffFirmNone.Click();
            return this;
        }

        public YourBusinessDetailsPage AddStaffFirmNoneDetails(string value = null)
        {
            if (value == null)
            {
                staffFirmNoneDetails.SendKeys("TestData");
            }
            else staffFirmNoneDetails.SendKeys(value);

            return this;
        }

        public YourBusinessDetailsPage DoSuedClient(string value)
        {
            WebDriver.WebActions().MoveToElement(certificateFooter).Perform();
            suedClient(value).Click();
            return this;
        }

        public YourBusinessDetailsPage AddRevenueNextYear(string value = null)
        {
            if (value == null)
            {
                revenueNextYear.SendKeys("20000");
            }
            else revenueNextYear.SendKeys(value);

            return this;
        }

        public YourBusinessDetailsPage AddRevenueCurrentYear(string value = null)
        {
            if (value == null)
            {
                revenueCurrentYear.SendKeys("20000");
            }
            else revenueCurrentYear.SendKeys(value);

            return this;
        }

        public YourBusinessDetailsPage AddRevenuePriorYear(string value = null)
        {
            if (value == null)
            {
                revenuePriorYear.SendKeys("20000");
            }
            else revenuePriorYear.SendKeys(value);

            return this;
        }

        public YourInsuranceHistoryPage NavigateToYourInsuranceHistoryPage()
        {
            continueButton.Click();
            return new YourInsuranceHistoryPage();
        }
    }
}
