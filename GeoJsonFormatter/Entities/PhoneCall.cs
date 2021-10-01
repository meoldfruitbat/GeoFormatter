using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class PhoneCall
    {
        public long Id { get; set; }
        public long OwnerId { get; set; }
        public long? EntityId { get; set; }
        public long? CompanyId { get; set; }
        public long ClientId { get; set; }
        public string Recipient { get; set; }
        public string Subject { get; set; }
        public string Direction { get; set; }
        public string Description { get; set; }
        public long? RegardingId { get; set; }
        public int CallDuration { get; set; }
        public DateTime DateEntered { get; set; }
        public string Priority { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Status { get; set; }
        public long? RecipientId { get; set; }
        public string RecipientPhone { get; set; }
        public string Regarding { get; set; }
        public DateTime? FollowUpDate { get; set; }
        public string Number { get; set; }
        public string EntityType { get; set; }
    }
}
