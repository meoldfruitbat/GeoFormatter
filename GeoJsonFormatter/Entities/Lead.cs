using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class Lead
    {
        public Lead()
        {
            EnquiryOtherContacts = new HashSet<EnquiryOtherContact>();
            EnquiryTaskStatuses = new HashSet<EnquiryTaskStatus>();
        }

        public long Id { get; set; }
        public string Topic { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Description { get; set; }
        public long? ClientId { get; set; }
        public long? CompanyId { get; set; }
        public long OwnerId { get; set; }
        public DateTime DateEntered { get; set; }
        public DateTime? DateModified { get; set; }
        public string Status { get; set; }
        public string LeadType { get; set; }
        public string Source { get; set; }
        public string Rating { get; set; }
        public string Region { get; set; }
        public string ClientSector { get; set; }
        public string WorkStreamSector { get; set; }
        public string PreferredContactMethod { get; set; }
        public bool AllowEmail { get; set; }
        public bool AllowPhoneCall { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string OverallLocation { get; set; }
        public string SpecificLocation { get; set; }
        public DateTime? QuoteRequiredBy { get; set; }
        public string EstimatedValue { get; set; }
        public DateTime? EstStartDate { get; set; }
        public string ProjectType { get; set; }
        public string ReasonToClose { get; set; }
        public string ReasonToCloseOther { get; set; }
        public bool? IsProspectingLead { get; set; }

        public virtual ICollection<EnquiryOtherContact> EnquiryOtherContacts { get; set; }
        public virtual ICollection<EnquiryTaskStatus> EnquiryTaskStatuses { get; set; }
    }
}
