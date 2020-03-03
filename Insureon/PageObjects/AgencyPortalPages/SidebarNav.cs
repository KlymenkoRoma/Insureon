using Framework.Selenium;
using Insureon.Selenium;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Insureon.PageObjects.AgencyPortalPages
{
    public class SidebarNav
    {
        private static Element home => WebDriver.FindElement(By.CssSelector("a[href='/home']"), "Home tab");
        private static Element viewClients => WebDriver.FindElement(By.CssSelector("a[href='/your-clients']"), "View Clients tab");
        private static Element expiringPolicies => WebDriver.FindElement(By.CssSelector("a[href='/expiring-policies']"), "Expiring Policies tab");
        private static Element viewQuotes => WebDriver.FindElement(By.CssSelector("a[href='/quotes']"), "View Quotes tab");
        private static Element startApplication => WebDriver.FindElement(By.CssSelector("a[href='/start-application']"), "Start Application tab");
        private static Element finishApplication => WebDriver.FindElement(By.CssSelector("a[href='/finish-application']"), "Finish Application tab");
        private static Element referenceTools => WebDriver.FindElement(By.CssSelector("a[href='/reference-tools']"), "Reference Tools tab");
        private static Element carrierLinks => WebDriver.FindElement(By.CssSelector("a[href='/carrier-links']"), "Carrier Links tab");
        private static Element contactUs => WebDriver.FindElement(By.CssSelector("a[href='contact-us']"), "Contact Us tab");

        public SidebarNav()
        {

        }

        public static void GoToHomeTab()
        {
            home.Click();
        }

        public static void GoToViewClientsTab()
        {
            viewClients.Click();
        }

        public static void GoToExpiringPoliciesTab()
        {
            expiringPolicies.Click();
        }

        public static void GoToViewQuotesTab()
        {
            viewQuotes.Click();
        }

        public static void GoToStartApplicationTab()
        {
            startApplication.Click();
        }

        public static void GoToFinishApplicationTab()
        {
            finishApplication.Click();
        }
    }
}
