using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class ContractsDayBook
    {
        public int Id { get; set; }
        public string ContractReference { get; set; }
        public decimal? SalesProvisionValue { get; set; }
        public decimal? Retention { get; set; }
        public DateTime? RetentionDate { get; set; }
        public string Action { get; set; }
        public DateTime? EmailSentWhen { get; set; }
        public string EmailTo { get; set; }
        public string EmailFrom { get; set; }
        public string Month { get; set; }
        public string Locked { get; set; }
        public string Year { get; set; }
    }
}
