﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Framework
{
    public class FrameWorkConfig
    {
        public DriverSettings Driver { get; set; }
        public TestSettings Test { get; set; }
    }

    public class DriverSettings
    {
        public string Browser { get; set; }
    }

    public class TestSettings
    {
        public string Url { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
