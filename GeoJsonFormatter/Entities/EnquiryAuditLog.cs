using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class EnquiryAuditLog
    {
        public long Id { get; set; }
        public long? EnquiryId { get; set; }
        public string LoggedInUser { get; set; }
        public string Action { get; set; }
        public DateTime? ActionedOn { get; set; }
    }
}
