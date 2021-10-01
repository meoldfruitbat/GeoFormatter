using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class CustomerEnquiryActionNote
    {
        public int Id { get; set; }
        public int? CustomerEnquiryId { get; set; }
        public string ActionType { get; set; }
        public string Notes { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }

        public virtual OperativeFile CreatedByNavigation { get; set; }
        public virtual CustomerEnquiryDetail CustomerEnquiry { get; set; }
    }
}
