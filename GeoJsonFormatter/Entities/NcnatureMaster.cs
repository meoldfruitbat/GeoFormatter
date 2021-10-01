using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class NcnatureMaster
    {
        public NcnatureMaster()
        {
            NonConformanceNatures = new HashSet<NonConformanceNature>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<NonConformanceNature> NonConformanceNatures { get; set; }
    }
}
