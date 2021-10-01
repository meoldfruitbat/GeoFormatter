using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class SubContractorTeam
    {
        public SubContractorTeam()
        {
            SubContractorTeamOperatives = new HashSet<SubContractorTeamOperative>();
        }

        public long Id { get; set; }
        public long? SubcontractorId { get; set; }
        public string TeamName { get; set; }
        public DateTime? CreatedOn { get; set; }
        public byte[] TimeStamp { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? DeletedOn { get; set; }

        public virtual ClientContractorFile Subcontractor { get; set; }
        public virtual ICollection<SubContractorTeamOperative> SubContractorTeamOperatives { get; set; }
    }
}
