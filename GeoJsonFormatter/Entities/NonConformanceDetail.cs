using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class NonConformanceDetail
    {
        public NonConformanceDetail()
        {
            NonConformanceActionNotes = new HashSet<NonConformanceActionNote>();
            NonConformanceActionTasks = new HashSet<NonConformanceActionTask>();
            NonConformanceAllocatedHistories = new HashSet<NonConformanceAllocatedHistory>();
            NonConformanceComments = new HashSet<NonConformanceComment>();
            NonConformanceCostActions = new HashSet<NonConformanceCostAction>();
            NonConformanceNatures = new HashSet<NonConformanceNature>();
            NonConformancePictures = new HashSet<NonConformancePicture>();
            NonConformanceReferences = new HashSet<NonConformanceReference>();
            NonConformanceResponsibles = new HashSet<NonConformanceResponsible>();
        }

        public int Id { get; set; }
        public long? RecordedBy { get; set; }
        public DateTime? RecordedDate { get; set; }
        public DateTime? IncidentDateTime { get; set; }
        public short? SourceOfComplaint { get; set; }
        public string ComplainantName { get; set; }
        public string ComplainantTelephone { get; set; }
        public string ComplainantEmail { get; set; }
        public string ComplainantAddress { get; set; }
        public long? AgreedBy { get; set; }
        public bool? Nctype { get; set; }
        public short? Status { get; set; }
        public short? Priority { get; set; }
        public long? AllocatedTo { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public long? LastModifiedBy { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public byte[] Timestamp { get; set; }
        public string ImmediateAction { get; set; }
        public string CorrectiveAction { get; set; }
        public string PreventiveAction { get; set; }
        public int? CustomerEnquiryId { get; set; }
        public bool? CostElement { get; set; }
        public decimal? CostofNcr { get; set; }
        public int? CostRecoverable { get; set; }
        public string RootCause { get; set; }
        public long? InvestigatedBy { get; set; }
        public bool? CompanyResponsiblefor { get; set; }
        public bool? SupplierResponsiblefor { get; set; }
        public bool? InvestigationComplete { get; set; }
        public long? Closedoffby { get; set; }
        public bool? Actiontaskscomplete { get; set; }
        public long? Verifiedby { get; set; }
        public string CorrectiveActionComments { get; set; }
        public string CorrectiveActionLessons { get; set; }
        public bool ClientNotifiable { get; set; }
        public string ComplainantStreet { get; set; }
        public string ComplainantTownCity { get; set; }
        public string ComplainantPostalcode { get; set; }
        public decimal? ActualCostOfNcr { get; set; }
        public Guid? AuditId { get; set; }
        public string Category { get; set; }
        public decimal? QuestionId { get; set; }

        public virtual Audit Audit { get; set; }
        public virtual ICollection<NonConformanceActionNote> NonConformanceActionNotes { get; set; }
        public virtual ICollection<NonConformanceActionTask> NonConformanceActionTasks { get; set; }
        public virtual ICollection<NonConformanceAllocatedHistory> NonConformanceAllocatedHistories { get; set; }
        public virtual ICollection<NonConformanceComment> NonConformanceComments { get; set; }
        public virtual ICollection<NonConformanceCostAction> NonConformanceCostActions { get; set; }
        public virtual ICollection<NonConformanceNature> NonConformanceNatures { get; set; }
        public virtual ICollection<NonConformancePicture> NonConformancePictures { get; set; }
        public virtual ICollection<NonConformanceReference> NonConformanceReferences { get; set; }
        public virtual ICollection<NonConformanceResponsible> NonConformanceResponsibles { get; set; }
    }
}
