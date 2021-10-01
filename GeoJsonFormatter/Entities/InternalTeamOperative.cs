using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class InternalTeamOperative
    {
        public long Id { get; set; }
        public long InternalTeamId { get; set; }
        public long OperativeId { get; set; }
        public bool IsTeamLead { get; set; }

        public virtual InternalTeam InternalTeam { get; set; }
        public virtual OperativeFile Operative { get; set; }
    }
}
