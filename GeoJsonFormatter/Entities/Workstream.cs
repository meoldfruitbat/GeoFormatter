using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class Workstream
    {
        public Workstream()
        {
            SupplierDetailReferences = new HashSet<SupplierDetailReference>();
            TeamWorkStreams = new HashSet<TeamWorkStream>();
        }

        public int Id { get; set; }
        public string Workstream1 { get; set; }

        public virtual ICollection<SupplierDetailReference> SupplierDetailReferences { get; set; }
        public virtual ICollection<TeamWorkStream> TeamWorkStreams { get; set; }
    }
}
