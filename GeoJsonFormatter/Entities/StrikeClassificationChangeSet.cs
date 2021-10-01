using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class StrikeClassificationChangeSet
    {
        public int Id { get; set; }
        public string StrikeClassification { get; set; }
        public DateTime? RiddornotificationDate { get; set; }
        public long? PublicUtilityDamageId { get; set; }
        public int? InvestigationId { get; set; }
        public DateTime? InputOn { get; set; }
        public bool? IsFinal { get; set; }

        public virtual PublicUtilityDamageInvestigation Investigation { get; set; }
        public virtual PublicUtilityDamage PublicUtilityDamage { get; set; }
    }
}
