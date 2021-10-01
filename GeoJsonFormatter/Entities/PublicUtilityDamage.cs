using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class PublicUtilityDamage
    {
        public PublicUtilityDamage()
        {
            PublicUtilityDamageChangeSets = new HashSet<PublicUtilityDamageChangeSet>();
            PublicUtilityDamageInvestigations = new HashSet<PublicUtilityDamageInvestigation>();
            PublicUtilityDamagePictures = new HashSet<PublicUtilityDamagePicture>();
            PublicUtilityDamageReports = new HashSet<PublicUtilityDamageReport>();
            PublicUtilityDamageSignatures = new HashSet<PublicUtilityDamageSignature>();
            PublicUtilityDamageWitnesses = new HashSet<PublicUtilityDamageWitness>();
            PublicUtilityDescriptionOfIncidentChangeSets = new HashSet<PublicUtilityDescriptionOfIncidentChangeSet>();
            PublicUtilityIndirectCauses = new HashSet<PublicUtilityIndirectCause>();
            PublicUtilityInjuredPersonnel = new HashSet<PublicUtilityInjuredPersonnel>();
            PublicUtilityInvestigationAnswers = new HashSet<PublicUtilityInvestigationAnswer>();
            PublicUtilityOtherPersonInvolveds = new HashSet<PublicUtilityOtherPersonInvolved>();
            StrikeClassificationChangeSets = new HashSet<StrikeClassificationChangeSet>();
            UtilityStrikeActionNotes = new HashSet<UtilityStrikeActionNote>();
            UtilityStrikeActionTasks = new HashSet<UtilityStrikeActionTask>();
            UtilityStrikeFinalReports = new HashSet<UtilityStrikeFinalReport>();
            UtilityStrikeResponsibles = new HashSet<UtilityStrikeResponsible>();
        }

        public long CodeId { get; set; }
        public string ContractReference { get; set; }
        public DateTime? RecordedDateTime { get; set; }
        public string RecordedBy { get; set; }
        public string Location { get; set; }
        public string Responsibility { get; set; }
        public string ContractType { get; set; }
        public string WorksType { get; set; }
        public string Notes { get; set; }
        public string Status { get; set; }
        public string DamageTypeId { get; set; }
        public DateTime? IncidentDateTime { get; set; }
        public string ReportedBy { get; set; }
        public string ReportedByCompany { get; set; }
        public long? UtilityId { get; set; }
        public string UtilityContactName { get; set; }
        public string UtilityReference { get; set; }
        public string ContractorResponsibleId { get; set; }
        public string ContractorResponsibleContactName { get; set; }
        public DateTime? UtilityContactedDateTime { get; set; }
        public string DamageLocation { get; set; }
        public string UtilityContactNumber { get; set; }
        public string AnswerOne { get; set; }
        public string AnswerTwo { get; set; }
        public string AnswerThree { get; set; }
        public string AnswerFour { get; set; }
        public bool? Injuries { get; set; }
        public string ContractorResponsibleContactNumber { get; set; }
        public DateTime? ClientContactedDateTime { get; set; }
        public long? SupervisorAssigned { get; set; }
        public bool? IsClientContacted { get; set; }
        public string Severity { get; set; }
        public string FinalReportVisitorLogIds { get; set; }
        public string FinalReportSelectedDocIds { get; set; }
        public string ReasonForReOpenInvestigation { get; set; }
        public Guid? PublicUtilityDamageGuid { get; set; }

        public virtual ICollection<PublicUtilityDamageChangeSet> PublicUtilityDamageChangeSets { get; set; }
        public virtual ICollection<PublicUtilityDamageInvestigation> PublicUtilityDamageInvestigations { get; set; }
        public virtual ICollection<PublicUtilityDamagePicture> PublicUtilityDamagePictures { get; set; }
        public virtual ICollection<PublicUtilityDamageReport> PublicUtilityDamageReports { get; set; }
        public virtual ICollection<PublicUtilityDamageSignature> PublicUtilityDamageSignatures { get; set; }
        public virtual ICollection<PublicUtilityDamageWitness> PublicUtilityDamageWitnesses { get; set; }
        public virtual ICollection<PublicUtilityDescriptionOfIncidentChangeSet> PublicUtilityDescriptionOfIncidentChangeSets { get; set; }
        public virtual ICollection<PublicUtilityIndirectCause> PublicUtilityIndirectCauses { get; set; }
        public virtual ICollection<PublicUtilityInjuredPersonnel> PublicUtilityInjuredPersonnel { get; set; }
        public virtual ICollection<PublicUtilityInvestigationAnswer> PublicUtilityInvestigationAnswers { get; set; }
        public virtual ICollection<PublicUtilityOtherPersonInvolved> PublicUtilityOtherPersonInvolveds { get; set; }
        public virtual ICollection<StrikeClassificationChangeSet> StrikeClassificationChangeSets { get; set; }
        public virtual ICollection<UtilityStrikeActionNote> UtilityStrikeActionNotes { get; set; }
        public virtual ICollection<UtilityStrikeActionTask> UtilityStrikeActionTasks { get; set; }
        public virtual ICollection<UtilityStrikeFinalReport> UtilityStrikeFinalReports { get; set; }
        public virtual ICollection<UtilityStrikeResponsible> UtilityStrikeResponsibles { get; set; }
    }
}
