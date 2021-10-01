using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class NonConformanceReport
    {
        public long CodeId { get; set; }
        public string ContractReference { get; set; }
        public DateTime? RecordedDate { get; set; }
        public string ProblemDescription { get; set; }
        public string RecordedBy { get; set; }
        public DateTime? CompletionDate { get; set; }
        public string Responsibility { get; set; }
        public string Source { get; set; }
        public string ProblemPo { get; set; }
        public string ProblemType { get; set; }
        public string ProblemCause { get; set; }
        public string ProblemAction { get; set; }
        public string ProblemAssociates { get; set; }
        public string ProblemPrevention { get; set; }
        public string CauseAssessedBy { get; set; }
        public string CorrectiveActionBy { get; set; }
        public string PreventativeActionBy { get; set; }
        public string ClosedBy { get; set; }
        public DateTime? ClosedDate { get; set; }
        public DateTime? ReviewDate { get; set; }
        public string AgreedBy { get; set; }
        public string ClaimGang { get; set; }
        public string ClaimSupervisor { get; set; }
        public string ClaimOperatives { get; set; }
        public string ContactName { get; set; }
        public string ContactId { get; set; }
        public string ClientName { get; set; }
        public string ClientId { get; set; }
        public string IssueNumber { get; set; }
        public string Status { get; set; }
        public string Protaganists { get; set; }
    }
}
