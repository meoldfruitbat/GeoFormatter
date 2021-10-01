using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class SdhMusReconciliationJobMovement
    {
        public long Id { get; set; }
        public int? RecId { get; set; }
        public int? OrderId { get; set; }
        public decimal? Total { get; set; }
        public decimal? X1 { get; set; }
        public decimal? X2 { get; set; }

        public virtual SdhMusReconciliationSummary Rec { get; set; }
    }
}
