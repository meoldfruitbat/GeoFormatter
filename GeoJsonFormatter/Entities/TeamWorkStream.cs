using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class TeamWorkStream
    {
        public int TeamId { get; set; }
        public int WorkStreamId { get; set; }
        public bool? IsActive { get; set; }

        public virtual TeamDetail Team { get; set; }
        public virtual Workstream WorkStream { get; set; }
    }
}
