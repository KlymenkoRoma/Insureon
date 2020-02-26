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
    public class YourProtectionPage : BaseUniAppPage
    {
        private Element GL => WebDriver.FindElement(By.XPath("//label[text()='General Liability']"), "GL");
        private Element BOP => WebDriver.FindElement(By.XPath("//label[contains(text(), 'Business Owner')]"), "BOP");
        private Element InlandMarine => WebDriver.FindElement(By.XPath("//label[text()='Inland Marine']"), "Inland Marine");
        private Element Umbrella => WebDriver.FindElement(By.XPath("//label[text()='Umbrella (Excess Liability)']"), "Umbrella");
        private Element NonOwnAuto => WebDriver.FindElement(By.XPath("//label[text()='Hired and Non-owned Auto Liability (coverage for vehicles not titled to your business)']"), "Non Own Auto");
        private Element CommercialAuto => WebDriver.FindElement(By.XPath("//label[text()='Commercial Auto Liability (for vehicles titled to your business)']"), "Commercial Auto");
        private Element WC => WebDriver.FindElement(By.XPath("//label[contains(text(), 'Compensation / Employers')]"), "WC");
        private Element ErrorsOmissions => WebDriver.FindElement(By.XPath("//label[text()='Professional Liability / Errors and Omissions']"), "Errors & Omissions");

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
