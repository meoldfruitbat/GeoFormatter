using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class NonConformanceNature
    {
        public int Id { get; set; }
        public int? NonConformanceId { get; set; }
        public int? NatureId { get; set; }

        public virtual NcnatureMaster Nature { get; set; }
        public virtual NonConformanceDetail NonConformance { get; set; }
    }
}
