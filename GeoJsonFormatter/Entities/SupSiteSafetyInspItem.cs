using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class SupSiteSafetyInspItem
    {
        public long Id { get; set; }
        public string LogRef { get; set; }
        public int? ItemNumber { get; set; }
        public string ItemCategory { get; set; }
    }
}
