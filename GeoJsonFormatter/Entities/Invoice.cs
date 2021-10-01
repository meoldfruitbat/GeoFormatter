using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class Invoice
    {
        public long Id { get; set; }
        public string InvoiceGuid { get; set; }
        public DateTime Date { get; set; }
        public DateTime? DueDate { get; set; }
        public string InvoiceNumber { get; set; }
        public string Reference { get; set; }
        public DateTime? ExpectedPaymentDate { get; set; }
        public DateTime? PlannedPaymentDate { get; set; }
        public decimal SubTotal { get; set; }
        public decimal TotalTax { get; set; }
        public decimal Total { get; set; }
        public decimal? TotalDiscount { get; set; }
        public bool? IsDiscounted { get; set; }
        public decimal? AmountDue { get; set; }
        public decimal? AmountPaid { get; set; }
        public DateTime? FullyPaidOnDate { get; set; }
        public decimal? AmountCredited { get; set; }
        public DateTime UpdatedDateUtc { get; set; }
        public string Attachments { get; set; }
        public bool? IsSupplier { get; set; }
        public bool? IsCustomer { get; set; }
        public string ContactName { get; set; }
        public string ContactGuid { get; set; }
    }
}
