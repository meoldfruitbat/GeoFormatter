using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class EventSeverity
    {
        public int Id { get; set; }
        public string Severity { get; set; }
        public string AlertLevel { get; set; }
        public string Category { get; set; }
        public int? OldRef { get; set; }
    }
}
