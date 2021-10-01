using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class CustomerEnquiryAllocatedHistory
    {
        public int Id { get; set; }
        public int? CustomerEnquiryId { get; set; }
        public long? OldValue { get; set; }
        public long? NewValue { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }

        public virtual CustomerEnquiryDetail CustomerEnquiry { get; set; }
    }
}
