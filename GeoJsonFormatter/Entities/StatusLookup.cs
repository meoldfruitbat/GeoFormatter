using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class StatusLookup
    {
        public long CodeId { get; set; }
        public string Status { get; set; }
        public string ShortDesc { get; set; }
        public string DisplayColour { get; set; }
        public string BelongTo { get; set; }
        public int? ImageId { get; set; }
        public int? OrderBy { get; set; }
    }
}
