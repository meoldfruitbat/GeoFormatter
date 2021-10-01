using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class ReferenceDatum
    {
        public ReferenceDatum()
        {
            ContractorDetailReferences = new HashSet<ContractorDetailReference>();
            ContractorDetails = new HashSet<ContractorDetail>();
            ItemStockTransferHistories = new HashSet<ItemStockTransferHistory>();
            ManageEmailReferenceTableNavigations = new HashSet<ManageEmail>();
            ManageEmailStatusNavigations = new HashSet<ManageEmail>();
            Orders = new HashSet<Order>();
            SupplierDetailReferences = new HashSet<SupplierDetailReference>();
            SupplierDetails = new HashSet<SupplierDetail>();
        }

        public int Id { get; set; }
        public int RefCategoryId { get; set; }
        public string DisplayString { get; set; }
        public string DataValue { get; set; }
        public int? DisplaySequence { get; set; }

        public virtual RefCategory RefCategory { get; set; }
        public virtual ICollection<ContractorDetailReference> ContractorDetailReferences { get; set; }
        public virtual ICollection<ContractorDetail> ContractorDetails { get; set; }
        public virtual ICollection<ItemStockTransferHistory> ItemStockTransferHistories { get; set; }
        public virtual ICollection<ManageEmail> ManageEmailReferenceTableNavigations { get; set; }
        public virtual ICollection<ManageEmail> ManageEmailStatusNavigations { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<SupplierDetailReference> SupplierDetailReferences { get; set; }
        public virtual ICollection<SupplierDetail> SupplierDetails { get; set; }
    }
}
