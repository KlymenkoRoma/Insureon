using Framework;
using Framework.Selenium;
using Insureon.Selenium;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Insureon.PageObjects.AgencyPortalPages
{
    public class ViewClientsPage
    {
        private Element searchField => WebDriver.FindElement(By.CssSelector("input.input-table-search"), "Search Field");
        private Element clientName(string name) => WebDriver.FindElement(By.XPath($"//table//a[text()='{name}']"), "Client record");

        public ViewClientsPage()
        {

        }

        public ViewClientsPage GoTo()
        {
            SidebarNav.GoToViewClientsTab();
            return this;
        }

        public ViewClientsPage SearchClient(string name)
        {
            searchField.SendKeys(name);
            searchField.SendKeys(Keys.Enter);
            return this;
        }

        public ClientDetailsPage NavigateToClientDetailsPage(string name)
        {
            clientName(name).Click();
            return new ClientDetailsPage();
        }
    }
}
