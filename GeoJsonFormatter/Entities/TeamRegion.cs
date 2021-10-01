using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class TeamRegion
    {
        public int TeamId { get; set; }
        public long RegionId { get; set; }
        public bool? IsActive { get; set; }

        public virtual Region Region { get; set; }
        public virtual TeamDetail Team { get; set; }
    }
}
