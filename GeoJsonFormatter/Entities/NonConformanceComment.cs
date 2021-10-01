using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class NonConformanceComment
    {
        public int Id { get; set; }
        public int? NonConformanceId { get; set; }
        public string Notes { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }

        public virtual NonConformanceDetail NonConformance { get; set; }
    }
}
