using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class TeamProject
    {
        public long Id { get; set; }
        public int TeamId { get; set; }
        public long QuoteId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? IsLabourOrPlant { get; set; }
    }
}
