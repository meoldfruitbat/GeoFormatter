using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class Cvi
    {
        public Cvi()
        {
            CvidetailsHistoryLogs = new HashSet<CvidetailsHistoryLog>();
            Cvipictures = new HashSet<Cvipicture>();
            CvischedulerNotificationEmails = new HashSet<CvischedulerNotificationEmail>();
            CvistatusUpdateLogs = new HashSet<CvistatusUpdateLog>();
            ProjectWorks = new HashSet<ProjectWork>();
            Valuations = new HashSet<Valuation>();
        }

        public long Cvino { get; set; }
        public string ScdcontractId { get; set; }
        public string ContractId { get; set; }
        public string WorkId { get; set; }
        public string InstructionTo { get; set; }
        public string AttentionOf { get; set; }
        public string ClientEmail { get; set; }
        public string ContractName { get; set; }
        public string Location { get; set; }
        public string IssueDate { get; set; }
        public string Instruction { get; set; }
        public bool? ScheduleRates { get; set; }
        public bool? DayworkRates { get; set; }
        public bool? SpecifiedPrice { get; set; }
        public bool? PriceToBeAgreed { get; set; }
        public bool Prolongation { get; set; }
        public bool? Other { get; set; }
        public string OtherSpecified { get; set; }
        public bool? WillCarryOutWork { get; set; }
        public bool? AwaitingWrittenInstruction { get; set; }
        public string IssuedByDate { get; set; }
        public bool DistributedByHand { get; set; }
        public bool DistributedByEmail { get; set; }
        public bool DistributedByFax { get; set; }
        public bool DistributedByPost { get; set; }
        public string ConfirmationPrintName { get; set; }
        public string ConfirmationDate { get; set; }
        public string ConfirmationOnBehalfOf { get; set; }
        public DateTime DateReceived { get; set; }
        public string PathToPdf { get; set; }
        public string IssuedBy { get; set; }
        public string CvirelatedTo { get; set; }
        public bool ContractIdverified { get; set; }
        public string ContractReference { get; set; }
        public string ProjectName { get; set; }
        public long? GangLeaderId { get; set; }
        public long? SupervisorId { get; set; }
        public short? Status { get; set; }
        public string StatusChangedBy { get; set; }
        public string StatusChangedReason { get; set; }
        public string CostingsFile { get; set; }
        public string Scdsignature { get; set; }
        public string ClientSignature { get; set; }
        public string Picture1 { get; set; }
        public string Picture2 { get; set; }
        public bool? CvifromIpad { get; set; }
        public Guid? AssignmentId { get; set; }
        public long? QuoteId { get; set; }
        public string FromAddress { get; set; }
        public string ToAddress { get; set; }
        public Guid? CviId { get; set; }
        public int? NoHomesAdded { get; set; }
        public int? NoHomesRemoved { get; set; }
        public bool? IsUrgent { get; set; }
        public string ProjectManagerReference { get; set; }
        public DateTime? PmrdateTimeReceived { get; set; }
        public string InstructionDetails { get; set; }
        public long? LastModifiedBy { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public int? CompletedBy { get; set; }
        public int? Agreedby { get; set; }
        public string AgreedbyEmail { get; set; }
        public byte[] Timestamp { get; set; }
        public int? SubStatus { get; set; }
        public DateTime? CostSubmittedDate { get; set; }
        public DateTime? PosubmittedDate { get; set; }
        public string WhoGavePmi { get; set; }
        public string Ponumber { get; set; }
        public string ApprovalCode { get; set; }
        public long? ApprovedDfe { get; set; }
        public string PoprovidedBy { get; set; }
        public string BeingChargedAt { get; set; }
        public string HomesAffected { get; set; }
        public string CancellationReason { get; set; }
        public string TimestampForValuation { get; set; }
        public long? AllocatedTo { get; set; }
        public decimal? ActualDfevalue { get; set; }
        public string CostPreparedBy { get; set; }
        public bool? ChangeInCost { get; set; }
        public bool? InstructedByClient { get; set; }

        public virtual Assignment Assignment { get; set; }
        public virtual ICollection<CvidetailsHistoryLog> CvidetailsHistoryLogs { get; set; }
        public virtual ICollection<Cvipicture> Cvipictures { get; set; }
        public virtual ICollection<CvischedulerNotificationEmail> CvischedulerNotificationEmails { get; set; }
        public virtual ICollection<CvistatusUpdateLog> CvistatusUpdateLogs { get; set; }
        public virtual ICollection<ProjectWork> ProjectWorks { get; set; }
        public virtual ICollection<Valuation> Valuations { get; set; }
    }
}
