using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class Gang
    {
        public Gang()
        {
            GangOperatives = new HashSet<GangOperative>();
        }

        public long Id { get; set; }
        public long GangLeaderId { get; set; }
        public bool Active { get; set; }
        public int? SubcontractorLabourTeamId { get; set; }
        public string SubcontractorLabourTeamName { get; set; }
        public long? SubContractorCompanyId { get; set; }

        public virtual ICollection<GangOperative> GangOperatives { get; set; }
    }
}
