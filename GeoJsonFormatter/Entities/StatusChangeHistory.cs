using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class StatusChangeHistory
    {
        public int StatusChangeHistoryId { get; set; }
        public string ContractRef { get; set; }
        public string QuoteId { get; set; }
        public string Info { get; set; }
        public string Status { get; set; }
        public string Agent { get; set; }
        public DateTime? DateTime { get; set; }
    }
}
