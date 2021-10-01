using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class DatabaseFirewallRule
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string StartIpAddress { get; set; }
        public string EndIpAddress { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModifyDate { get; set; }
    }
}
