﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KHerring.Models
{
    public class Event
    {
        public DateTime EventDate { get; set; }
        public string EventName { get; set; }
        public string EventLocation { get; set; }
    }
}