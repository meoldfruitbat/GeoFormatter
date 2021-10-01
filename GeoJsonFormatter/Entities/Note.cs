using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class Note
    {
        public long Id { get; set; }
        public long? CompanyId { get; set; }
        public long? LeadId { get; set; }
        public long? AppointmentId { get; set; }
        public long? TaskId { get; set; }
        public long? EmailId { get; set; }
        public long? PhoneCallId { get; set; }
        public string Note1 { get; set; }
        public DateTime DateEntered { get; set; }
        public long OwnerId { get; set; }
        public long? QuoteId { get; set; }
        public int? CandidatePhoneCallId { get; set; }
    }
}
