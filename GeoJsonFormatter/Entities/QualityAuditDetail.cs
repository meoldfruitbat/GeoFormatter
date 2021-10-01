using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class QualityAuditDetail
    {
        public int Id { get; set; }
        public long AuditId { get; set; }
        public int? TotalAuditScore { get; set; }
        public int WorkTypeId { get; set; }
        public int? PhotoScore { get; set; }
        public int? QualityScore { get; set; }
        public string Comments { get; set; }

        public virtual WorkTypeLookup WorkType { get; set; }
    }
}
