using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class PublicUtilityInvestigationAnswer
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public long PublicUtilityDamageId { get; set; }
        public string Answer { get; set; }
        public string Comments { get; set; }
        public int? InvestigationId { get; set; }
        public DateTime? InputOn { get; set; }
        public bool? IsFinal { get; set; }

        public virtual PublicUtilityDamage PublicUtilityDamage { get; set; }
        public virtual PublicUtilityInvestigationQuestion Question { get; set; }
    }
}
