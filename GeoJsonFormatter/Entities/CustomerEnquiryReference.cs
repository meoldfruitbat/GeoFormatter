using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class CustomerEnquiryReference
    {
        public int Id { get; set; }
        public int? NonConformanceId { get; set; }
        public long? ReferenceId { get; set; }
        public long? QuoteId { get; set; }
        public short? Type { get; set; }

        public virtual CustomerEnquiryDetail NonConformance { get; set; }
    }
}
