﻿using Framework.Logging;
using Newtonsoft.Json;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Framework
{
    public class FrameWork
    {
        public static string WORKSPACE_DIRECTORY = Path.GetFullPath(@"../../../../");
        public static Logger Log => _logger ?? throw new NullReferenceException("_logger is null. SetLogger() first.");
        public static FrameWorkConfig Config => _configuration ?? throw new NullReferenceException("Config is null. Call Fw.SetConfig() first.");

        [ThreadStatic]
        public static DirectoryInfo CurrentTestDirectory;

        [ThreadStatic]
        public static Logger _logger;

        private static FrameWorkConfig _configuration;

        public static DirectoryInfo CreateTestResultsDirectory()
        {
            var testDirectory = WORKSPACE_DIRECTORY + "TestResults";

            if (Directory.Exists(testDirectory))
            {
                Directory.Delete(testDirectory, recursive: true);
            }

            return Directory.CreateDirectory(testDirectory);
        }

        public static void SetConfig()
        {
            if (_configuration == null)
            {
                var jsonStr = File.ReadAllText(WORKSPACE_DIRECTORY + "/framework-config.json");
                _configuration = JsonConvert.DeserializeObject<FrameWorkConfig>(jsonStr);
            }
        }

        public static void SetLogger()
        {
            lock (_setLoggerLock)
            {
                var testResultsDir = WORKSPACE_DIRECTORY + "TestResults";
                var testName = TestContext.CurrentContext.Test.Name.Replace("\"", "");
                var fullPath = $"{testResultsDir}\\{testName}";

                if (Directory.Exists(fullPath))
                {
                    CurrentTestDirectory = Directory.CreateDirectory(fullPath + TestContext.CurrentContext.Test.ID);
                }
                else
                {
                    CurrentTestDirectory = Directory.CreateDirectory(fullPath);
                }

                _logger = new Logger(testName, CurrentTestDirectory.FullName + "/log.txt");
            }
        }

        private static object _setLoggerLock = new object();
    }
}
