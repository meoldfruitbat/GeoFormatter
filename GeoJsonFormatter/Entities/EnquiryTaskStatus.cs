using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class EnquiryTaskStatus
    {
        public long Id { get; set; }
        public long? LeadId { get; set; }
        public int? EnquiryTaskId { get; set; }
        public string TaskStatus { get; set; }
        public long? QuoteId { get; set; }

        public virtual GenericValue EnquiryTask { get; set; }
        public virtual Lead Lead { get; set; }
    }
}
