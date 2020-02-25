using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Insureon.Selenium;

namespace Insureon.PageObjects.UniversallAppPages
{
    public class YourInformationPage : BaseUniAppPage
    {
        private IWebElement firstName => WebDriver.FindElement(By.XPath("//label[text()='Your first name']//following-sibling::input"));
        private IWebElement lastName => WebDriver.FindElement(By.XPath("//label[text()='Your last name']//following-sibling::input"));
        private IWebElement phone => WebDriver.FindElement(By.XPath("//label[text()='Contact Phone Number']//following-sibling::input"));
        private IWebElement email => WebDriver.FindElement(By.XPath("//label[text()='Email']//following-sibling::input"));
        private IWebElement coverageStart => WebDriver.FindElement(By.XPath("//span[text()='What date would you like your coverage to start?']//parent::p//following-sibling::div//input"));

        public YourInformationPage()
        {

        }

        public YourInformationPage AddFirstName(string value = null)
        {
            if (value == null)
            {
                firstName.SendKeys(new Bogus.DataSets.Name().FirstName());
            }
            else firstName.SendKeys(value);

            return this;
        }

        public YourInformationPage AddLastName(string value = null)
        {
            if (value == null)
            {
                lastName.SendKeys(new Bogus.DataSets.Name().LastName());
            }
            else lastName.SendKeys(value);

            return this;
        }

        public YourInformationPage AddPhone(string value = null)
        {
            if (value == null)
            {
                phone.SendKeys(random.Number(2, 9).ToString() + random.Number(11, 99) + random.Number(2, 9) + random.Number(111111, 999999));
            }
            else phone.SendKeys(value);

            return this;
        }

        public YourInformationPage AddEmail(string value = null)
        {
            if (value == null)
            {
                email.SendKeys(bissnessName + "@mail.com");
            }
            else email.SendKeys(value);

            return this;
        }

        public YourInformationPage AddCoverageStart(string value = null)
        {
            if (value == null)
            {
                coverageStart.SendKeys(DateTime.Today.AddDays(30).ToString("MMddyyyy"));
            }
            else coverageStart.SendKeys(value);

            return this;
        }

        public YourCompanyHistoryPage NavigateToYourCompanyHistoryPage()
        {
            continueButton.Click();
            return new YourCompanyHistoryPage();
        }
    }
}
