using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class InvoiceLineItem
    {
        public long Id { get; set; }
        public string InvoiceGuid { get; set; }
        public string LineItemGuid { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitAmount { get; set; }
        public string TaxType { get; set; }
        public decimal TaxAmount { get; set; }
        public string AccountCode { get; set; }
        public long? ProjectQnumber { get; set; }
        public string TrackingCategoryGuid { get; set; }
        public string TrackingName { get; set; }
        public string TrackingOption { get; set; }
    }
}
