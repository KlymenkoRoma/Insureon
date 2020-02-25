using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Text;

namespace Framework.Selenium
{
    public class WebDriverFactory
    {
        public static IWebDriver Build(string browserName)
        {
            FrameWork.Log.Info($"Browser: {browserName}");

            switch (browserName)
            {
                case "chrome":
                    return new ChromeDriver(SetOptions());

                case "firefox":
                    return new FirefoxDriver();

                default:
                    throw new System.ArgumentException($"{browserName} not supported");
            }
        }

        private static ChromeOptions SetOptions()
        {
            var options = new ChromeOptions();
            options.AddArguments("--start-maximized");

            return options;
        }
    }
}
