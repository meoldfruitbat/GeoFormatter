using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class ItemSupplier
    {
        public ItemSupplier()
        {
            ItemStocks = new HashSet<ItemStock>();
        }

        public int Id { get; set; }
        public int ItemId { get; set; }
        public long SupplierId { get; set; }
        public decimal Price { get; set; }

        public virtual Item Item { get; set; }
        public virtual ClientCompanyFile Supplier { get; set; }
        public virtual ICollection<ItemStock> ItemStocks { get; set; }
    }
}
