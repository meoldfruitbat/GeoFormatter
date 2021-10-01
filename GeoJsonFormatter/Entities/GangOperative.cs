using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class GangOperative
    {
        public long Id { get; set; }
        public long OperativeId { get; set; }
        public long GangId { get; set; }
        public bool? Active { get; set; }

        public virtual Gang Gang { get; set; }
    }
}
