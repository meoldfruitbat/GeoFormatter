using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class AuditExpectedPhoto
    {
        public int Id { get; set; }
        public int? PhotoType { get; set; }
        public decimal? PerUnitValue { get; set; }
        public int Type { get; set; }
        public string Unit { get; set; }
        public long QuoteId { get; set; }
        public long AuditId { get; set; }

        public virtual PictureReason PhotoTypeNavigation { get; set; }
        public virtual WorkTypeLookup TypeNavigation { get; set; }
    }
}
