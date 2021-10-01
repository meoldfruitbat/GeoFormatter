using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class AuditLogForWorksRate
    {
        public long Id { get; set; }
        public long QuoteId { get; set; }
        public string ViewedBy { get; set; }
        public DateTime ViewedOn { get; set; }
        public short Type { get; set; }

        public virtual QuoteFile Quote { get; set; }
    }
}
