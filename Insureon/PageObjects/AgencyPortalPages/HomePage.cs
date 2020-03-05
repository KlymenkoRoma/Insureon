using Insureon.PageObjects.UniversallAppPages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Insureon.Selenium;
using Framework.Selenium;
using Insureon.PageObjects.AgencyPortalPages;
using System.Threading;

namespace Insureon.PageObjects.BasePages
{
    public class HomePage
    {
        public HomePage()
        {

        }

        public ViewClientsPage NavigateToViewClientsPage()
        {
            WebDriver.Timeout(15);
            return new ViewClientsPage();
        }

        public StartApplicationPage NavigateToStartApplicationPage()
        {
            WebDriver.Timeout(15);
            return new StartApplicationPage();
        }
    }
}
