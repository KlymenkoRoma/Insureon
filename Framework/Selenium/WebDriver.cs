using Framework;
using Framework.Selenium;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insureon.Selenium
{
    public static class WebDriver
    {
        [ThreadStatic] private static IWebDriver driver;

        public static IWebDriver GetDriver()
        {
            if (driver == null)
                driver = WebDriverFactory.Build(FrameWork.Config.Driver.Browser);
            return driver;
        }

        public static void GoTo(string url)
        {
            if (!url.StartsWith("http"))
            {
                url = $"https://{url}";
            }

            FrameWork.Log.Info(url);
            driver.Navigate().GoToUrl(url);
        }

        public static Element FindElement(By by, string elementName)
        {
            return new Element(driver.FindElement(by), elementName)
            {
                FoundBy = by
            };
        }

        public static Element FindElement(By by)
        {
            return new Element(driver.FindElement(by))
            {
                FoundBy = by
            };
        }

        public static Elements FindElements(By by)
        {
            return new Elements(driver.FindElements(by))
            {
                FoundBy = by
            };
        }

        public static void Timeout(int sec)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(sec);
        }

        public static Actions WebActions()
        {
            return new Actions(driver);
        }

        public static void TakeScreenshot(string imageName)
        {
            var ss = ((ITakesScreenshot)driver).GetScreenshot();
            var ssFileName = Path.Combine(FrameWork.CurrentTestDirectory.FullName, imageName);
            ss.SaveAsFile($"{ssFileName}.png", ScreenshotImageFormat.Png);
        }

        public static void Quit()
        {
            FrameWork.Log.Info("Close Browser");
            driver.Quit();
        }
    }
}
