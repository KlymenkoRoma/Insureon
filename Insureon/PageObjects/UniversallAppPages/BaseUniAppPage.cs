using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Insureon.Selenium;
using Bogus;
using Framework.Selenium;

namespace Insureon.PageObjects.UniversallAppPages
{
    public class BaseUniAppPage
    {
        public Element continueButton => WebDriver.FindElement(By.Id("nextBtn"), "Continue button");
        public Element backButton => WebDriver.FindElement(By.Id("backBtn"), "Back button");
        public Element submitButton => WebDriver.FindElement(By.XPath("//button[text()='Submit Application']"), "Submit button");
        public Element certificateFooter => WebDriver.FindElement(By.XPath("//div[@class='certificate']"), "Certificate");

        public static Randomizer random = new Randomizer();
        public static string currentDate = DateTime.Today.ToString("MMddyy");
        public string bissnessName = "testatom_k" + currentDate + random.Number(1, 99);

        public BaseUniAppPage()
        {

        }
    }
}
