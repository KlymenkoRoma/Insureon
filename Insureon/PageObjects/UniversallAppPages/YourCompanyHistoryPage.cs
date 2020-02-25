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
    public class YourCompanyHistoryPage : BaseUniAppPage
    {
        private Element startOfBussiness => WebDriver.FindElement(By.XPath("//span[text()='What date did your business begin under current ownership?']//parent::p//following-sibling::div//input"), "Start Of Bussiness");
        private Element yearsExperience => WebDriver.FindElement(By.Id("q-13"), "Years Experience");
        private Element businessRegistered(string bussType) => WebDriver.FindElement(By.XPath($"//*[@id='q-14']/button[text()='{bussType}']"), $"Business Registered: {bussType}");
        private Element dateOfBirth => WebDriver.FindElement(By.XPath("//span[text()='Your date of birth']//parent::p//following-sibling::div//input"), "Date Of Birth");
        private Element employees => WebDriver.FindElement(By.Id("q-19"), "Employees");
        private Element annualPayroll => WebDriver.FindElement(By.XPath("//label[text()='What is the total annual payroll for your entire office?']//following-sibling::input"), "Annual Payroll");

        public YourCompanyHistoryPage()
        {
            
        }

        public YourCompanyHistoryPage AddStartOfBussiness(string value = null)
        {
            if (value == null)
            {
                startOfBussiness.SendKeys(new DateTime(2015, 04, 10).ToString("MMddyyyy"));
            }
            else startOfBussiness.SendKeys(value);

            return this;
        }

        public YourCompanyHistoryPage AddYearsOfExperience(string value = null)
        {
            if (value == null)
            {
                yearsExperience.SendKeys("1");
            }
            else yearsExperience.SendKeys(value);

            return this;
        }

        public YourCompanyHistoryPage AddBusinessRegistered(string value)
        {
            businessRegistered(value).Click();
            return this;
        }

        public YourCompanyHistoryPage AddDOB(string value = null)
        {
            if (value == null)
            {
                dateOfBirth.SendKeys(new DateTime(1989, 04, 10).ToString("MMddyyyy"));
            }
            else dateOfBirth.SendKeys(value);

            return this;
        }

        public YourCompanyHistoryPage AddNumberOfEmployees(string value = null)
        {
            if (value == null)
            {
                employees.SendKeys("1");
            }
            else employees.SendKeys(value);

            return this;
        }

        public YourCompanyHistoryPage AddAnnualPayroll(string value = null)
        {
            if (value == null)
            {
                annualPayroll.SendKeys("20000");
            }
            else annualPayroll.SendKeys(value);

            return this;
        }

        public YourLocationsPage NavigateToYourLocationsPage()
        {
            continueButton.Click();
            return new YourLocationsPage();
        }
    }
}
