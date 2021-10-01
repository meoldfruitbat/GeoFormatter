using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderItems = new HashSet<OrderItem>();
        }

        public int Id { get; set; }
        public string OrderNo { get; set; }
        public string PurchaseOrderNo { get; set; }
        public DateTime? RequiredByDate { get; set; }
        public decimal? OrderValue { get; set; }
        public long? SupplierId { get; set; }
        public long? ProjectId { get; set; }
        public int? Status { get; set; }
        public bool IsDeliveryTypeOrder { get; set; }
        public string DeliveryAddress { get; set; }
        public string ContactTelNo { get; set; }
        public int? RequisitionType { get; set; }
        public string DeliveryNotes { get; set; }
        public string OrderNotes { get; set; }
        public long? OrderedBy { get; set; }
        public DateTime? OrderedDate { get; set; }
        public int? ApproverId { get; set; }
        public byte[] TimeStamp { get; set; }
        public bool IsOrderedByCompany { get; set; }
        public long? IssueTo { get; set; }
        public bool? IsIssuedToPerson { get; set; }
        public int? IsGoodsReceivedNoteUnavailable { get; set; }
        public bool IsInternalOrder { get; set; }
        public string DeliveryDriver { get; set; }
        public DateTime? DispatchDate { get; set; }
        public string ReasonForRejection { get; set; }
        public string PurchaseOrderId { get; set; }
        public DateTime? UpdatedDateUtc { get; set; }
        public string Attachments { get; set; }
        public string OrphanSupplierName { get; set; }
        public string OrphanSupplierId { get; set; }
        public string PurchaseOrderGuid { get; set; }

        public virtual ContractFile Project { get; set; }
        public virtual ReferenceDatum StatusNavigation { get; set; }
        public virtual ClientCompanyFile Supplier { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
