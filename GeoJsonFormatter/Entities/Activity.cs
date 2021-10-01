using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class Activity
    {
        public long Id { get; set; }
        public long? OwnerId { get; set; }
        public string ActivityType { get; set; }
        public long? LeadId { get; set; }
        public long? CompanyId { get; set; }
        public long? EmailId { get; set; }
        public long? PhoneCallId { get; set; }
        public long? AppointmentId { get; set; }
        public long? TaskId { get; set; }
        public DateTime DateEntered { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Status { get; set; }
        public long? AddedBy { get; set; }
    }
}
