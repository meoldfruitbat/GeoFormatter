using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class JobCostingTransaction
    {
        public int Id { get; set; }
        public int? TransactionId { get; set; }
        public int? LinkId { get; set; }
        public int? JobId { get; set; }
        public int? Chid { get; set; }
        public string Reference { get; set; }
        public string Name { get; set; }
        public DateTime? RecordDate { get; set; }
        public string Ref1 { get; set; }
        public string Ref2 { get; set; }
        public string Details { get; set; }
        public int? NomCode { get; set; }
        public int? DeptCode { get; set; }
        public decimal? CostQuantity { get; set; }
        public decimal CostRate { get; set; }
        public decimal? Net { get; set; }
        public decimal? ChargeQuantity { get; set; }
        public decimal? ChargeRate { get; set; }
        public decimal? ChargeAmount { get; set; }
        public decimal? TaxCode { get; set; }
        public decimal? Tax { get; set; }
        public decimal? Total { get; set; }
        public string PostingStatus { get; set; }
        public int? PurchaseOrderHeaderId { get; set; }
        public int? PurchaseOrderItemId { get; set; }
        public int? PurchaseOrderJobItemId { get; set; }
        public string LastUser { get; set; }
        public DateTime? DateTimeStamp { get; set; }
        public DateTime? LastUpdateTime { get; set; }
    }
}
