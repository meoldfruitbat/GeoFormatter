using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class NonConformanceResponsible
    {
        public long Id { get; set; }
        public string ResponsibleType { get; set; }
        public long? ResponsibleId { get; set; }
        public string DebitorCredit { get; set; }
        public decimal? Amount { get; set; }
        public decimal? TotalAmount { get; set; }
        public int? Week { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? NonconformanceId { get; set; }

        public virtual NonConformanceDetail Nonconformance { get; set; }
    }
}
