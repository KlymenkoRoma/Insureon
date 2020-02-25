using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Insureon.Selenium;

namespace Insureon.PageObjects.UniversallAppPages
{
    public class YourProtectionPage : BaseUniAppPage
    {
        private IWebElement GL => WebDriver.FindElement(By.XPath("//label[text()='General Liability']"));
        private IWebElement BOP => WebDriver.FindElement(By.XPath("//label[contains(text(), 'Business Owner')]"));
        private IWebElement InlandMarine => WebDriver.FindElement(By.XPath("//label[text()='Inland Marine']"));
        private IWebElement Umbrella => WebDriver.FindElement(By.XPath("//label[text()='Umbrella (Excess Liability)']"));
        private IWebElement NonOwnAuto => WebDriver.FindElement(By.XPath("//label[text()='Hired and Non-owned Auto Liability (coverage for vehicles not titled to your business)']"));
        private IWebElement CommercialAuto => WebDriver.FindElement(By.XPath("//label[text()='Commercial Auto Liability (for vehicles titled to your business)']"));
        private IWebElement WC => WebDriver.FindElement(By.XPath("//label[contains(text(), 'Compensation / Employers')]"));
        private IWebElement ErrorsOmissions => WebDriver.FindElement(By.XPath("//label[text()='Professional Liability / Errors and Omissions']"));

        public YourProtectionPage()
        {

        }

        public YourProtectionPage SelectGL()
        {
            GL.Click();
            return this;
        }

        public YourProtectionPage SelectBOP()
        {
            BOP.Click();
            return this;
        }

        public YourProtectionPage SelectInlandMarine()
        {
            InlandMarine.Click();
            return this;
        }

        public YourProtectionPage SelectUmbrella()
        {
            Umbrella.Click();
            return this;
        }

        public YourProtectionPage SelectNonOwnAuto()
        {
            NonOwnAuto.Click();
            return this;
        }

        public YourProtectionPage SelectCommercialAuto()
        {
            CommercialAuto.Click();
            return this;
        }

        public YourProtectionPage SelectWC()
        {
            WC.Click();
            return this;
        }

        public YourProtectionPage SelectErrorsOmissions()
        {
            ErrorsOmissions.Click();
            return this;
        }

        public YourInformationPage NavigateToYourInformationPage()
        {
            continueButton.Click();
            return new YourInformationPage();
        }
    }
}
