using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class PublicUtilityDamageChangeSet
    {
        public int Id { get; set; }
        public string ContractReference { get; set; }
        public string Location { get; set; }
        public DateTime? IncidentDateTime { get; set; }
        public DateTime? ClientContactedDateTime { get; set; }
        public DateTime? UtilityContactedDateTime { get; set; }
        public string Notes { get; set; }
        public long? PublicUtilityDamageId { get; set; }
        public int? InvestigationId { get; set; }
        public DateTime? InputOn { get; set; }
        public bool? IsFinal { get; set; }
        public string UtilityReference { get; set; }
        public string UtilityContactName { get; set; }
        public string UtilityContactNumber { get; set; }
        public long? UtilityCompanyId { get; set; }

        public virtual PublicUtilityDamageInvestigation Investigation { get; set; }
        public virtual PublicUtilityDamage PublicUtilityDamage { get; set; }
    }
}
