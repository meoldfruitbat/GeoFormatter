using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class CandidateEmail
    {
        public int Id { get; set; }
        public int CandidateId { get; set; }
        public string EmailBody { get; set; }
        public string Subject { get; set; }
        public int EmailStatus { get; set; }
        public string SentTo { get; set; }
        public DateTime? DateSent { get; set; }
        public string Bcc { get; set; }
        public string Cc { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public short? TemplateId { get; set; }
        public string Priority { get; set; }
        public string AttachmentFile { get; set; }
        public bool? IsSendAtLeter { get; set; }
        public bool? IsDeliveredRecieptRequired { get; set; }
        public bool? IsReadRecieptRequired { get; set; }
        public bool? IsScheduleFollowUp { get; set; }
        public DateTime? DelayedDateTime { get; set; }
        public DateTime? FollowUpDateTime { get; set; }
        public long SentBy { get; set; }
        public DateTime CreatedOn { get; set; }

        public virtual Candidate Candidate { get; set; }
    }
}
