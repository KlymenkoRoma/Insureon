using Framework.Selenium;
using Insureon.Selenium;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Insureon.PageObjects.AgencyPortalPages
{
    public class CollectPaymentPage
    {
        public Element firstName => WebDriver.FindElement(By.CssSelector("select#firstName"));
        public Element lastName => WebDriver.FindElement(By.CssSelector("select#lastName"));
        public Element quoteDetailsActionDrop => WebDriver.FindElement(By.CssSelector("select.quote-actions"));
        public Element quoteDetailsActionDrop => WebDriver.FindElement(By.CssSelector("select.quote-actions"));
        public Element quoteDetailsActionDrop => WebDriver.FindElement(By.CssSelector("select.quote-actions"));
        public Element quoteDetailsActionDrop => WebDriver.FindElement(By.CssSelector("select.quote-actions"));
        public CollectPaymentPage()
        {

        }
    }
}
