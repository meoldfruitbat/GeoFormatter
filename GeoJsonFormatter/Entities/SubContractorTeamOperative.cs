using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class SubContractorTeamOperative
    {
        public long Id { get; set; }
        public long? SubContractorTeamId { get; set; }
        public long? OperativeId { get; set; }
        public bool? IsTeamLead { get; set; }

        public virtual OperativeFile Operative { get; set; }
        public virtual SubContractorTeam SubContractorTeam { get; set; }
    }
}
