﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Device
{
    public class Settings
    {
        public int Id { get; set; }
        public string User { get; set; }
        public DateTime Time1 { get; set; }
        public DateTime Time2 { get; set; }
        public DateTime Time3 { get; set; }
        public string Description { get; set; }
        public TimeSpan TimeDelta { get; set; }
    }
}
