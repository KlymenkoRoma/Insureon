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

namespace Insureon.PageObjects.BasePages
{
    public class HomePage
    {
        public HomePage()
        {

        }

        public ViewClientsPage NavigateToViewClientsPage()
        {
            return new ViewClientsPage();
        }

        public StartApplicationPage NavigateToStartApplicationPage()
        {
            return new StartApplicationPage();
        }
    }
}
