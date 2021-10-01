using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class PublicUtilityInjuredPersonnel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string ContactNumber { get; set; }
        public string Injuries { get; set; }
        public string NextOfKinName { get; set; }
        public string NextOfKinNumber { get; set; }
        public long PublicUtilityDamageId { get; set; }
        public int? InvestigationId { get; set; }
        public DateTime? InputOn { get; set; }
        public bool? IsFinal { get; set; }

        public virtual PublicUtilityDamage PublicUtilityDamage { get; set; }
    }
}
