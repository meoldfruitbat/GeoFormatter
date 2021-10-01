using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class TeamOperative
    {
        public int TeamId { get; set; }
        public long OperativeId { get; set; }
        public bool IsTeamLead { get; set; }
        public decimal? FinancialSplit { get; set; }
        public decimal? TempFinancialSplit { get; set; }
        public int DisplayOrder { get; set; }
        public DateTime? AddUntill { get; set; }
        public bool? AddPermanent { get; set; }
        public bool? IsActive { get; set; }
        public bool IsDaywork { get; set; }
        public bool IsDayworkTemp { get; set; }

        public virtual OperativeFile Operative { get; set; }
        public virtual TeamDetail Team { get; set; }
    }
}
