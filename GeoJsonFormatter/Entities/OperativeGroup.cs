using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class OperativeGroup
    {
        public OperativeGroup()
        {
            OperativeManagers = new HashSet<OperativeManager>();
        }

        public int Id { get; set; }
        public int GroupId { get; set; }
        public long OperativeId { get; set; }

        public virtual OperativeGroup1 Group { get; set; }
        public virtual OperativeFile Operative { get; set; }
        public virtual ICollection<OperativeManager> OperativeManagers { get; set; }
    }
}
