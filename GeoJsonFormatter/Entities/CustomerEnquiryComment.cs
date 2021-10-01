using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class CustomerEnquiryComment
    {
        public int Id { get; set; }
        public int? NonConformanceId { get; set; }
        public string Notes { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }

        public virtual CustomerEnquiryDetail NonConformance { get; set; }
    }
}
