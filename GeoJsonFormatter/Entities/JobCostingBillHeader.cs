using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class JobCostingBillHeader
    {
        public long Id { get; set; }
        public long? BillHeaderId { get; set; }
        public long? InvoiceNo { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public long? JobId { get; set; }
        public string CustomerRef { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress1 { get; set; }
        public string CustomerAddress2 { get; set; }
        public string CustomerAddress3 { get; set; }
        public string CustomerAddress4 { get; set; }
        public string CustomerAddress5 { get; set; }
        public string OrderNumber { get; set; }
        public string Contact { get; set; }
        public string Telephone { get; set; }
        public string CustomerOrderNo { get; set; }
        public string OrderTakenBy { get; set; }
        public string CustomerEmail { get; set; }
        public decimal? ItemsNet { get; set; }
        public decimal? ItemsTax { get; set; }
        public decimal? InvoiceNet { get; set; }
        public decimal? InvoiceTax { get; set; }
        public decimal? InvoiceGross { get; set; }
        public decimal? GlobalTaxRate { get; set; }
        public string LastUser { get; set; }
        public DateTime? DateTimeStamp { get; set; }
        public DateTime? DateTimeLastUpdate { get; set; }
        public string FullyInvoicedFlag { get; set; }
        public string OnHoldEmailSentCheck { get; set; }
    }
}
