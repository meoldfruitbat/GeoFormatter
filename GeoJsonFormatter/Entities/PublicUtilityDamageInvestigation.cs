using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class PublicUtilityDamageInvestigation
    {
        public PublicUtilityDamageInvestigation()
        {
            PublicUtilityDamageChangeSets = new HashSet<PublicUtilityDamageChangeSet>();
            PublicUtilityDescriptionOfIncidentChangeSets = new HashSet<PublicUtilityDescriptionOfIncidentChangeSet>();
            StrikeClassificationChangeSets = new HashSet<StrikeClassificationChangeSet>();
        }

        public int Id { get; set; }
        public long PublicUtilityDamageId { get; set; }
        public long AgentId { get; set; }
        public DateTime InvestigationDate { get; set; }
        public string StrikeClassification { get; set; }
        public DateTime? RiddornotificationDate { get; set; }
        public string SurfaceMaterial { get; set; }
        public bool? DamagedUtilityPrintsProvided { get; set; }
        public bool? PrintsAdequateInformation { get; set; }
        public bool? PrintsColour { get; set; }
        public string EventLeadingToIncident { get; set; }
        public string ImmediateActionTaken { get; set; }
        public bool? ElectricPrintsProvided { get; set; }
        public bool? GasPrintsProvided { get; set; }
        public bool? WaterPrintsProvided { get; set; }
        public bool? BtprintsProvided { get; set; }
        public bool? SewerPrintsProvided { get; set; }
        public bool? CctvprintsProvided { get; set; }
        public int? SignatureId { get; set; }
        public string CurrentInvestigationStatus { get; set; }
        public string ImmediateDirectCause { get; set; }

        public virtual OperativeFile Agent { get; set; }
        public virtual PublicUtilityDamage PublicUtilityDamage { get; set; }
        public virtual PublicUtilityDamageSignature Signature { get; set; }
        public virtual ICollection<PublicUtilityDamageChangeSet> PublicUtilityDamageChangeSets { get; set; }
        public virtual ICollection<PublicUtilityDescriptionOfIncidentChangeSet> PublicUtilityDescriptionOfIncidentChangeSets { get; set; }
        public virtual ICollection<StrikeClassificationChangeSet> StrikeClassificationChangeSets { get; set; }
    }
}
