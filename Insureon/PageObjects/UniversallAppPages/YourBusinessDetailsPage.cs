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
    public class YourBusinessDetailsPage : BaseUniAppPage
    {
        private Element describeBusiness => WebDriver.FindElement(By.Id("q-61"), "Describe Business");
        private Element website(string value) => WebDriver.FindElement(By.XPath($"//div[@id='q-62']/input[@value='{value}']"), $"Website: {value}");
        private Element useAgreement(string value) => WebDriver.FindElement(By.XPath($"//div[@id='q-68']/button[text()='{value}']"), $"Use Agreement: {value}");
        private Element useDeclinationLetters(string value) => WebDriver.FindElement(By.XPath($"//div[@id='q-71']/input[@value='{value}']"), $"Use Declination Letters: {value}");
        private Element businessConsult(string value) => WebDriver.FindElement(By.XPath($"//div[@id='q-73']/input[@value='{value}']"), $"Business Consult: {value}");
        private Element tangibleGoods(string value) => WebDriver.FindElement(By.XPath($"//div[@id='q-74']/input[@value='{value}']"), $"Tangible Goods: {value}");
        private Element performDesign(string value) => WebDriver.FindElement(By.XPath($"//div[@id='q-77']/input[@value='{value}']"), $"Perform Design: {value}");
        private Element partTime(string value) => WebDriver.FindElement(By.XPath($"//div[@id='q-79']/input[@value='{value}']"), $"Part Time: {value}");
        private Element taxLiensBankruptcy(string value) => WebDriver.FindElement(By.XPath($"//div[@id='q-80']/input[@value='{value}']"), $"Tax Liens Bankruptcy: {value}");
        private Element subsidiaries(string value) => WebDriver.FindElement(By.XPath($"//div[@id='q-82']/input[@value='{value}']"), $"Subsidiaries: {value}");
        private Element crimeFraud(string value) => WebDriver.FindElement(By.XPath($"//div[@id='q-83']/input[@value='{value}']"), $"Crime Fraud: {value}");
        private Element ownHalf(string value) => WebDriver.FindElement(By.XPath($"//div[@id='q-84']/input[@value='{value}']"), $"Own Half: {value}");
        private Element ownerFirmNone => WebDriver.FindElement(By.XPath("//label[text()='Had their license revoked or suspended']"), "Owner Firm None");
        private Element staffFirmNone => WebDriver.FindElement(By.XPath("//label[text()='Provided services to any publicly held client']"), "Staff Firm None");
        private Element staffFirmNoneDetails => WebDriver.FindElement(By.Id("q-97"), "Staff Firm None Details");
        private Element suedClient(string value) => WebDriver.FindElement(By.XPath($"//div[@id='q-98']/input[@value='{value}']"), $"Sued Client: {value}");
        private Element revenueNextYear => WebDriver.FindElement(By.XPath("//label[text()='What will your revenue be for the next fiscal year?']//following-sibling::input"), "Revenue Next Year");
        private Element revenueCurrentYear => WebDriver.FindElement(By.XPath("//label[text()='What is your revenue for the current fiscal year?']//following-sibling::input"), "Revenue Current Year");
        private Element revenuePriorYear => WebDriver.FindElement(By.XPath("//label[text()='What was your revenue in the prior fiscal year?']//following-sibling::input"), "Revenue Prior Year");

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
