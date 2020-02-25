using Framework.Selenium;
using Insureon.PageObjects.UniversallAppPages;
using Insureon.Selenium;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insureon.PageObjects.AgencyPortalPages
{
    public class ClientDetailsPage
    {
        public Element BusinessName(string name) => WebDriver.FindElement(By.XPath($"//span[text()='Business Name:']/following-sibling::span[text()='{name}']"), $"Business Name: {name}");

        public ClientDetailsPage()
        {

        }
    }
}
