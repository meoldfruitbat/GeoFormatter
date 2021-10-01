using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class InternalTeam
    {
        public InternalTeam()
        {
            InternalTeamOperatives = new HashSet<InternalTeamOperative>();
        }

        public long Id { get; set; }
        public string TeamName { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool? IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedOn { get; set; }
        public byte[] Timestamp { get; set; }

        public virtual ICollection<InternalTeamOperative> InternalTeamOperatives { get; set; }
    }
}
