using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class UtilityStrikeActionTask
    {
        public int Id { get; set; }
        public string TaskName { get; set; }
        public string Requirements { get; set; }
        public DateTime? RequiredByDate { get; set; }
        public int? GroupId { get; set; }
        public long? AssignTo { get; set; }
        public string ActionType { get; set; }
        public long? PublicUtilityDamageId { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string EventId { get; set; }

        public virtual OperativeFile CreatedByNavigation { get; set; }
        public virtual OperativeGroup1 Group { get; set; }
        public virtual PublicUtilityDamage PublicUtilityDamage { get; set; }
    }
}
