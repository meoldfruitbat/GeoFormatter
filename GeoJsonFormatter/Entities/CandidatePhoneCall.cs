using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class CandidatePhoneCall
    {
        public int Id { get; set; }
        public int CandidateId { get; set; }
        public string Subject { get; set; }
        public string Direction { get; set; }
        public string Description { get; set; }
        public int CallDuration { get; set; }
        public string Priority { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Status { get; set; }
        public string RecipientPhone { get; set; }
        public DateTime? FollowUpDate { get; set; }
        public string Number { get; set; }
        public long CallBy { get; set; }
        public DateTime CreatedOn { get; set; }

        public virtual Candidate Candidate { get; set; }
    }
}
