using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class MaintenenceContractsLookup
    {
        public int Id { get; set; }
        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string ClientIds { get; set; }
        public string ClientNames { get; set; }
        public string OriginalContractId { get; set; }
        public string OriginalContractName { get; set; }
        public string ThisContractName { get; set; }
        public int? ResponseTime { get; set; }
        public string ContractDetail { get; set; }
        public string ContractClosed { get; set; }
        public DateTime? ContractStart { get; set; }
        public int? ContractValidity { get; set; }
        public string ResponsePeriod { get; set; }
    }
}
