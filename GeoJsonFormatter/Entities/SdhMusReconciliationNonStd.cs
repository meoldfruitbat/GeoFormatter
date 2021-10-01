using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class SdhMusReconciliationNonStd
    {
        public long Id { get; set; }
        public int? RecId { get; set; }
        public DateTime? Date { get; set; }
        public string InvVoreference { get; set; }
        public string Details { get; set; }
        public decimal? Value { get; set; }
        public string AuthorisedBy { get; set; }
        public int? CertNo { get; set; }

        public virtual SdhMusReconciliationSummary Rec { get; set; }
    }
}
