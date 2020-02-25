using System;
using System.IO;
using Framework;
using Insureon.Selenium;
using NUnit.Framework;
using NUnit.Framework.Interfaces;

namespace Insureon.UITests
{
    public class BaseTest
    {
        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            FrameWork.SetConfig();
            FrameWork.CreateTestResultsDirectory();
        }

        [SetUp]
        public void SetUp()
        {
            FrameWork.SetLogger();
            WebDriver.GetDriver();
            WebDriver.GoTo(FrameWork.Config.Test.Url);
        }

        [TearDown]
        public void TearDown()
        {
            var outcome = TestContext.CurrentContext.Result.Outcome.Status;

            if (outcome == TestStatus.Passed)
            {
                FrameWork.Log.Info("Outcome: Passed");
            }
            else if (outcome == TestStatus.Failed)
            {
                WebDriver.TakeScreenshot("test_failed");
                FrameWork.Log.Info("Outcome: Failed");
            }
            else
            {
                FrameWork.Log.Warning("Outcome: " + outcome);
            }

            WebDriver.Quit();
        }

        //[OneTimeTearDown]
        //public void OneTimeTearDown()
        //{
        //    //WebDriver.Quit();
        //}
    }
}
