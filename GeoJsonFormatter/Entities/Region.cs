using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class Region
    {
        public Region()
        {
            TeamRegions = new HashSet<TeamRegion>();
        }

        public long Id { get; set; }
        public string Region1 { get; set; }

        public virtual ICollection<TeamRegion> TeamRegions { get; set; }
    }
}
