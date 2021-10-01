using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class SharepointIssue
    {
        public long Id { get; set; }
        public string ReportedBy { get; set; }
        public string IssueRelatesTo { get; set; }
        public string TheProblem { get; set; }
        public DateTime? DateReported { get; set; }
        public string AssignedTo { get; set; }
        public DateTime? DateAssigned { get; set; }
        public DateTime? EstimatedTimeToComplete { get; set; }
        public string CompletedBy { get; set; }
        public DateTime? CompletedDate { get; set; }
        public string CompletedComments { get; set; }
    }
}
