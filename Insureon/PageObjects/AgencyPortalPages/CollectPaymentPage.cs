using Framework;
using Framework.Selenium;
using Insureon.Selenium;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Insureon.PageObjects.AgencyPortalPages
{
    public class CollectPaymentPage
    {
        public Element firstName => WebDriver.FindElement(By.CssSelector("input#firstName"));
        public Element lastName => WebDriver.FindElement(By.CssSelector("input#lastName"));
        public Element iframe => WebDriver.FindElement(By.Id("tx_iframe_tokenExIframeDiv"));
        public Element cardNumber => WebDriver.FindElement(By.Id("data"));
        public Element expirationMonth => WebDriver.FindElement(By.CssSelector("select#selectedMonth"));
        public Element expirationYear => WebDriver.FindElement(By.CssSelector("select#selectedYear"));
        public Element cvvCode => WebDriver.FindElement(By.CssSelector("input#cvv"));
        public Element submitButton => WebDriver.FindElement(By.XPath("//button[text()='Submit']"));
        public Element requestSubmittedText => WebDriver.FindElement(By.XPath("//p[text()='Your Bind Request has been submitted.']"));

        public CollectPaymentPage()
        {

        }

        public CollectPaymentPage AddFirstName()
        {
            firstName.SendKeys(new Bogus.DataSets.Name().FirstName());
            return this;
        }

        public CollectPaymentPage AddLastName()
        {
            lastName.SendKeys(new Bogus.DataSets.Name().LastName());
            return this;
        }

        public CollectPaymentPage AddCardNumber(string number)
        {
            WebDriver.SwitchToIframe(iframe);
            Thread.Sleep(3000);
            cardNumber.SendKeys(number);
            WebDriver.SwitchToMainContent();
            return this;
        }

        public CollectPaymentPage SelectExpirationMonth(string action)
        {
            FrameWork.Log.Step($"Select {action}");
            SetSomeValueFromDropDown(expirationMonth, action);
            return this;
        }

        public CollectPaymentPage SelectExpirationYear(string action)
        {
            FrameWork.Log.Step($"Select {action}");
            SetSomeValueFromDropDown(expirationYear, action);
            return this;
        }

        private void SetSomeValueFromDropDown(Element dropdown, string action)
        {
            SelectElement testElement = new SelectElement(dropdown);
            testElement.SelectByText(action);
        }

        public CollectPaymentPage AddCvvCode(string number)
        {
            cvvCode.SendKeys(number);
            return this;
        }

        public CollectPaymentPage SubmitRequest()
        {
            submitButton.Click();
            return this;
        }
    }
}
