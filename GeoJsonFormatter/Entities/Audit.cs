using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class Audit
    {
        public Audit()
        {
            NonConformanceDetails = new HashSet<NonConformanceDetail>();
        }

        public Guid AuditId { get; set; }
        public Guid AssignmentId { get; set; }
        public string GpsStart { get; set; }
        public string GpsEnd { get; set; }
        public string ProjectName { get; set; }
        public decimal? Score { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public DateTime? AuditDate { get; set; }
        public long NonConformancies { get; set; }
        public long? Inadequacies { get; set; }
        public long? Section1 { get; set; }
        public long? Section2 { get; set; }
        public long? Section3 { get; set; }
        public long? Section4 { get; set; }
        public long? Section5 { get; set; }
        public long? Section6 { get; set; }
        public long? Section7 { get; set; }
        public long? Section8 { get; set; }
        public long? Section9 { get; set; }
        public long? Section10 { get; set; }
        public long? GangLeaderId { get; set; }
        public string ConductedBy { get; set; }
        public string AuditorFocusId { get; set; }
        public string AuditorSignature { get; set; }
        public string AuditeeFocusId { get; set; }
        public string AuditeeSignature { get; set; }
        public string AdditionalComments { get; set; }
        public string AuditTime { get; set; }
        public long Id { get; set; }
        public string AuditorEmail { get; set; }
        public long? SupervisorId { get; set; }

        public virtual Assignment Assignment { get; set; }
        public virtual OperativeFile GangLeader { get; set; }
        public virtual ICollection<NonConformanceDetail> NonConformanceDetails { get; set; }
    }
}
