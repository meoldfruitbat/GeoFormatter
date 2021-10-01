using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class OrderBookItem
    {
        public long Id { get; set; }
        public DateTime? Date { get; set; }
        public string Supplier { get; set; }
        public string Description { get; set; }
        public long? Qty { get; set; }
        public decimal? PricePerUnit { get; set; }
        public decimal? PriceExcludingVat { get; set; }
        public string Contract { get; set; }
        public string OrderByName { get; set; }
        public long? QuoteNumber { get; set; }
        public long? OrderById { get; set; }
        public string AuthorisedByName { get; set; }
        public string ImageFileName { get; set; }
        public string AuthorisedById { get; set; }
        public string Comments { get; set; }
    }
}
