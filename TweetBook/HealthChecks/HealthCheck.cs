﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TweetBook.HealthChecks
{
    public class HealthCheck
    {
        public string Status { get; set; }
        public string Component { get; set; }
        public string Description { get; set; }
    }
}
