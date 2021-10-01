using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class TeamRole
    {
        public int TeamId { get; set; }
        public int RoleId { get; set; }
        public bool? IsActive { get; set; }

        public virtual Role Role { get; set; }
        public virtual TeamDetail Team { get; set; }
    }
}
