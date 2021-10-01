using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class IndustryLookup
    {
        public long IndustryId { get; set; }
        public string IndustryShort { get; set; }
        public string IndustryLong { get; set; }
        public int? IndustryCategory { get; set; }
    }
}
