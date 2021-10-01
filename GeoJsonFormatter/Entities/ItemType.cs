using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class ItemType
    {
        public ItemType()
        {
            ItemThresholds = new HashSet<ItemThreshold>();
            Items = new HashSet<Item>();
            PriceEnquiryItemTypes = new HashSet<PriceEnquiryItemType>();
            SupplierDetailReferences = new HashSet<SupplierDetailReference>();
        }

        public int Id { get; set; }
        public int GroupId { get; set; }
        public string Name { get; set; }

        public virtual ItemGroup Group { get; set; }
        public virtual ICollection<ItemThreshold> ItemThresholds { get; set; }
        public virtual ICollection<Item> Items { get; set; }
        public virtual ICollection<PriceEnquiryItemType> PriceEnquiryItemTypes { get; set; }
        public virtual ICollection<SupplierDetailReference> SupplierDetailReferences { get; set; }
    }
}
