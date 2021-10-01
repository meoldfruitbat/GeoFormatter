using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class Item
    {
        public Item()
        {
            ItemStockTransferHistories = new HashSet<ItemStockTransferHistory>();
            ItemStocks = new HashSet<ItemStock>();
            ItemSuppliers = new HashSet<ItemSupplier>();
            OrderItems = new HashSet<OrderItem>();
            ProductEnquiries = new HashSet<ProductEnquiry>();
        }

        public int Id { get; set; }
        public int ItemTypeId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int UnitTypeId { get; set; }
        public decimal? MinOrderQty { get; set; }
        public decimal? MaxOrderQty { get; set; }
        public bool IsStockItem { get; set; }
        public string Aisle { get; set; }
        public string PickLocation { get; set; }
        public decimal? CompanyPrice { get; set; }
        public string NominalCode { get; set; }

        public virtual ItemType ItemType { get; set; }
        public virtual UnitType UnitType { get; set; }
        public virtual ICollection<ItemStockTransferHistory> ItemStockTransferHistories { get; set; }
        public virtual ICollection<ItemStock> ItemStocks { get; set; }
        public virtual ICollection<ItemSupplier> ItemSuppliers { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
        public virtual ICollection<ProductEnquiry> ProductEnquiries { get; set; }
    }
}
