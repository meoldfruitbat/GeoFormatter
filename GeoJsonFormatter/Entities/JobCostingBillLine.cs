using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class JobCostingBillLine
    {
        public long Id { get; set; }
        public int? BillLineId { get; set; }
        public int? BillHeaderId { get; set; }
        public string ItemGridPosition { get; set; }
        public string Details { get; set; }
        public decimal? LineValue { get; set; }
        public decimal? TaxRate { get; set; }
        public decimal? Net { get; set; }
        public decimal? Tax { get; set; }
        public decimal? Gross { get; set; }
        public string PostingDetails { get; set; }
        public string LastUser { get; set; }
        public DateTime? DateTimeStamp { get; set; }
        public DateTime? DateTimeLastUpdate { get; set; }
    }
}
