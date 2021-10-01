using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class PublicUtilityIndirectCause
    {
        public int Id { get; set; }
        public string ElementId { get; set; }
        public string Explanation { get; set; }
        public string Weighting { get; set; }
        public int ReportId { get; set; }
        public long? PublicUtilityDamageId { get; set; }
        public int? Rcno { get; set; }

        public virtual PublicUtilityDamage PublicUtilityDamage { get; set; }
        public virtual PublicUtilityDamageReport Report { get; set; }
    }
}
