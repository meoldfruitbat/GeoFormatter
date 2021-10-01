﻿using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class CordovaSsid
    {
        public long Id { get; set; }
        public string GangLeaderName { get; set; }
        public Guid Ssid { get; set; }
        public DateTime Ssiddate { get; set; }
        public string SupervisorName { get; set; }
    }
}
