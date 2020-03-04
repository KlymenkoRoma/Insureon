using Framework;
using Framework.Selenium;
using Insureon.PageObjects.UniversallAppPages;
using Insureon.Selenium;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insureon.PageObjects.AgencyPortalPages
{
    public class ClientDetailsPage
    {
        public Element businessName(string name) => WebDriver.FindElement(By.XPath($"//span[text()='Business Name:']/following-sibling::span[text()='{name}']"));
        public Element viewQuoteDetails => WebDriver.FindElement(By.XPath("//span[text()='Quoted']//ancestor::div[3]//a[text()='View Quote Details']"), "View Quote Details");
        public Element quoteDetailsActionDrop => WebDriver.FindElement(By.CssSelector("select.quote-actions"));
        public Element submitButton => WebDriver.FindElement(By.CssSelector("button.submit-quote-action"), "Submit Button");

        public readonly SubmitBindRequestPopUp BindPopup;

        public ClientDetailsPage()
        {
            BindPopup = new SubmitBindRequestPopUp();
        }

        public ClientDetailsPage SelectQuoteDetails()
        {
            viewQuoteDetails.Click();
            return this;
        }

        public ClientDetailsPage SelectQuoteAction(string action)
        {
            FrameWork.Log.Step($"Select {action}");
            SetSomeValueFromDropDown(quoteDetailsActionDrop, action);
            return this;
        }

        public ClientDetailsPage SubmitQuoteAction()
        {
            submitButton.Click();
            return this;
        }

        private void SetSomeValueFromDropDown(Element dropdown, string action)
        {
            SelectElement testElement = new SelectElement(dropdown);
            testElement.SelectByText(action);
        }
    }

    public class SubmitBindRequestPopUp
    {
        public Element effectiveDate => WebDriver.FindElement(By.XPath("//label[contains(text(), 'Effective Date')]//following-sibling::div//input"), "Effective Date");
        public Element paymentPlan => WebDriver.FindElement(By.XPath("//label[contains(text(), 'Payment Plan')]//following-sibling::select"), "Payment Plan");
        public Element paymentMethod => WebDriver.FindElement(By.XPath("//label[contains(text(), 'Payment Method')]//following-sibling::select"), "Payment Method");
        public Element submitBindRequestButton => WebDriver.FindElement(By.CssSelector("button#submit-bind-request"), "Submit Bind Request button");

        public SubmitBindRequestPopUp()
        {

        }

        public SubmitBindRequestPopUp SelectEffectiveDate()
        {
            effectiveDate.SendKeys(DateTime.Today.ToString("MM/dd/yyyy"));
            return this;
        }

        public SubmitBindRequestPopUp SelectPaymentPlan(string action)
        {
            FrameWork.Log.Step($"Select {action}");
            SetSomeValueFromDropDown(paymentPlan, action);
            return this;
        }

        public SubmitBindRequestPopUp SelectPaymentMethod(string action)
        {
            FrameWork.Log.Step($"Select {action}");
            SetSomeValueFromDropDown(paymentMethod, action);
            return this;
        }

        private void SetSomeValueFromDropDown(Element dropdown, string action)
        {
            SelectElement testElement = new SelectElement(dropdown);
            testElement.SelectByText(action);
        }

        public CollectPaymentPage SubmitQuoteAction()
        {
            submitBindRequestButton.Click();
            return new CollectPaymentPage();
        }
    }
}
