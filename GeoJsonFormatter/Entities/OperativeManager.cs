using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class OperativeManager
    {
        public int Id { get; set; }
        public int ManagerId { get; set; }
        public long OperativeId { get; set; }
        public int GroupId { get; set; }
        public bool IsGroup { get; set; }

        public virtual OperativeGroup Manager { get; set; }
        public virtual OperativeFile Operative { get; set; }
    }
}
