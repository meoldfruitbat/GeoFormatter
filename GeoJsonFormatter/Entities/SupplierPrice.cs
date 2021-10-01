using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class SupplierPrice
    {
        public long Id { get; set; }
        public string Supplier { get; set; }
        public string Level4Category { get; set; }
        public string Level3Category { get; set; }
        public string Level2Category { get; set; }
        public string Level1Category { get; set; }
        public string Description { get; set; }
        public string OrderCode { get; set; }
        public decimal? UnitPrice { get; set; }
        public int? QtyPriceReqFor { get; set; }
        public DateTime? DatePriceRequired { get; set; }
        public DateTime? DatePriceReceived { get; set; }
        public string EachUnit { get; set; }
        public string LocationPriceValidFor { get; set; }
        public string PriceIssueBy { get; set; }
        public string Sid { get; set; }
        public string Industry { get; set; }
        public string Notes { get; set; }
        public string PurchaseOrderNo { get; set; }
        public DateTime? DatePurchased { get; set; }
        public string StockReference { get; set; }
        public DateTime? DateDueIn { get; set; }
        public Guid? ComponentCategoryId { get; set; }
        public int? Qty2order { get; set; }
        public string PriceRequestedBy { get; set; }
        public string PurchaseRequestFulfilled { get; set; }
        public string DeliveryCost { get; set; }
        public string DeliveryLocation { get; set; }
        public string ItemFullyReceived { get; set; }
        public string Pofulfilled { get; set; }
        public string SupplierAccountNo { get; set; }
        public string PaymentMethod { get; set; }
    }
}
