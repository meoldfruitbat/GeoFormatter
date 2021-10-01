using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class Variation
    {
        public long VariationId { get; set; }
        public string ContractReference { get; set; }
        public string QuoteId { get; set; }
        public string ContractId { get; set; }
        public string WorkId { get; set; }
        public string ClientId { get; set; }
        public string ProjectName { get; set; }
        public string ReasonForVariation { get; set; }
        public decimal? EstimatedCost { get; set; }
        public decimal? TrueCost { get; set; }
        public DateTime? LoggedDateTime { get; set; }
    }
}
