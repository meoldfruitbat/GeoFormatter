using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class PublicUtilityDescriptionOfIncidentChangeSet
    {
        public int Id { get; set; }
        public string DescriptionType { get; set; }
        public string Description { get; set; }
        public long? PublicUtilityDamageId { get; set; }
        public int? InvestigationId { get; set; }
        public DateTime? InputOn { get; set; }
        public bool? IsFinal { get; set; }

        public virtual PublicUtilityDamageInvestigation Investigation { get; set; }
        public virtual PublicUtilityDamage PublicUtilityDamage { get; set; }
    }
}
