using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class InvoicePayment
    {
        public long Id { get; set; }
        public string InvoiceGuid { get; set; }
        public string PaymentGuid { get; set; }
        public string Status { get; set; }
        public string PaymentType { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public DateTime UpdatedDateUtc { get; set; }
        public string Reference { get; set; }
        public bool? IsReconciled { get; set; }
    }
}
