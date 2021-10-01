using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class ScdCableStockAudit
    {
        public long Id { get; set; }
        public string CableDrumNo { get; set; }
        public string CableType { get; set; }
        public int? FibreCoreCount { get; set; }
        public int? InStock { get; set; }
        public bool? Tested { get; set; }
    }
}
