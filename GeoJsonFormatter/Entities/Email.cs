using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class Email
    {
        public long Id { get; set; }
        public long OwnerId { get; set; }
        public long? EntityId { get; set; }
        public long? CompanyId { get; set; }
        public long? ClientId { get; set; }
        public string EmailBody { get; set; }
        public string Subject { get; set; }
        public DateTime DateEntered { get; set; }
        public string Status { get; set; }
        public string EmailStatus { get; set; }
        public string SentTo { get; set; }
        public DateTime? DateSent { get; set; }
        public string Bcc { get; set; }
        public string Cc { get; set; }
        public long? RegardingId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Duration { get; set; }
        public short TemplateId { get; set; }
        public string Priority { get; set; }
        public string AttachmentFile { get; set; }
        public bool? IsSendAtLeter { get; set; }
        public bool? IsDeliveredRecieptRequired { get; set; }
        public bool? IsReadRecieptRequired { get; set; }
        public bool? IsScheduleFollowUp { get; set; }
        public DateTime? DelayedDateTime { get; set; }
        public DateTime? FollowUpDateTime { get; set; }
        public string EntityType { get; set; }
    }
}
