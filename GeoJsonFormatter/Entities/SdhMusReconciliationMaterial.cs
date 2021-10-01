using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class SdhMusReconciliationMaterial
    {
        public long Id { get; set; }
        public int? RecId { get; set; }
        public string PurchasingContract { get; set; }
        public string PurchasingNo { get; set; }
        public string PurchasingStatus { get; set; }
        public DateTime? PurchasingOrderDate { get; set; }
        public string PurchasingSupplier { get; set; }
        public string Description { get; set; }
        public int? OrderQty { get; set; }
        public int? QtyReceived { get; set; }
        public decimal? OrderedPrice { get; set; }
        public decimal? TotalOrderedPrice { get; set; }
        public string PurchasingRequestedByMorrison { get; set; }
        public string PurchasingSiteContactName { get; set; }
        public string PurchasingDeliverto { get; set; }
        public string PurchasingNotes { get; set; }
        public string PurchasingSubContractor { get; set; }
        public decimal? Total { get; set; }

        public virtual SdhMusReconciliationSummary Rec { get; set; }
    }
}
