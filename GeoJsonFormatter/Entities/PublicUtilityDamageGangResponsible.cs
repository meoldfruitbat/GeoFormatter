using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class PublicUtilityDamageGangResponsible
    {
        public int Id { get; set; }
        public long OperativeId { get; set; }
        public long GangLeaderId { get; set; }
        public long SupervisorId { get; set; }
        public long PublicUtilityDamagesId { get; set; }
        public int? InvestigationId { get; set; }
        public DateTime? InputOn { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? IsFinal { get; set; }

        public virtual OperativeFile Operative { get; set; }
    }
}
