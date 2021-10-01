using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class UtilityStrikeActionNote
    {
        public int Id { get; set; }
        public string ActionType { get; set; }
        public string Notes { get; set; }
        public long? PublicUtilityDamageId { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }

        public virtual OperativeFile CreatedByNavigation { get; set; }
        public virtual PublicUtilityDamage PublicUtilityDamage { get; set; }
    }
}
