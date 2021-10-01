using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class UtilityStrikeResponsible
    {
        public long Id { get; set; }
        public string ResponsibleType { get; set; }
        public long? ResponsibleId { get; set; }
        public string DebitorCredit { get; set; }
        public decimal? Amount { get; set; }
        public decimal? TotalAmount { get; set; }
        public int? Week { get; set; }
        public long? PublicUtilityDamageId { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }

        public virtual PublicUtilityDamage PublicUtilityDamage { get; set; }
    }
}
