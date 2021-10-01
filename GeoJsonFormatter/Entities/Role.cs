﻿using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class Role
    {
        public Role()
        {
            TeamRoles = new HashSet<TeamRole>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<TeamRole> TeamRoles { get; set; }
    }
}