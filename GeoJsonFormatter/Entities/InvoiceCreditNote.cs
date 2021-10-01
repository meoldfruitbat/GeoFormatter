using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class InvoiceCreditNote
    {
        public long Id { get; set; }
        public string InvoiceGuid { get; set; }
        public string CreditNoteGuid { get; set; }
        public DateTime Date { get; set; }
        public decimal SubTotal { get; set; }
        public decimal TotalTax { get; set; }
        public decimal Total { get; set; }
        public DateTime UpdatedDateUtc { get; set; }
        public DateTime? FullyPaidOnDate { get; set; }
        public string CreditNoteNumber { get; set; }
        public string Reference { get; set; }
        public decimal? RemainingCredit { get; set; }
        public decimal? AppliedAmount { get; set; }
    }
}
