using Framework.Selenium;
using Insureon.Selenium;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insureon.PageObjects.UniversallAppPages
{
    public class OptionalDiscountsPage : BaseUniAppPage
    {
        private Element BOP => WebDriver.FindElement(By.XPath("//label[text()='BOP']"), "BOP checkbox");

        public OptionalDiscountsPage()
        {

        }

        public OptionalDiscountsPage SelectBOP()
        {
            BOP.Click();
            return this;
        }

        public ReviewAndConfirmApplicationPage NavigateToReviewAndConfirmApplicationPage()
        {
            continueButton.Click();
            return new ReviewAndConfirmApplicationPage();
        }
    }
}
