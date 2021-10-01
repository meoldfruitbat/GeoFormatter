using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class FaultActivity
    {
        public long Id { get; set; }
        public long FaultId { get; set; }
        public int Type { get; set; }
        public string Description { get; set; }
        public long AddedBy { get; set; }
        public DateTime AddedOn { get; set; }
        public int? RepairStatus { get; set; }
        public long? OperativeId { get; set; }

        public virtual FaultMaster Fault { get; set; }
        public virtual OperativeFile Operative { get; set; }
    }
}
