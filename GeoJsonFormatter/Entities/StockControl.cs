using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class StockControl
    {
        public Guid Id { get; set; }
        public string ItemDescription { get; set; }
        public string Reference { get; set; }
        public string ApplicableTo { get; set; }
        public string PurchaseOrderNo { get; set; }
        public DateTime? DatePurchased { get; set; }
        public DateTime? DateReceived { get; set; }
        public string ContractReference { get; set; }
        public long? OperativeId { get; set; }
        public DateTime? DateAssigned { get; set; }
        public long BarCode { get; set; }
        public long? Sid { get; set; }
        public Guid? CategoryId { get; set; }
        public int? ItemNo { get; set; }
    }
}
