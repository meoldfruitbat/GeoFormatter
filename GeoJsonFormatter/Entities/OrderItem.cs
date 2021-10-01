using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class OrderItem
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ItemId { get; set; }
        public string Specification { get; set; }
        public string Size { get; set; }
        public decimal? Quantity { get; set; }
        public int? UnitType { get; set; }
        public decimal? Rate { get; set; }
        public decimal? NetTotal { get; set; }
        public decimal? QuantityReceived { get; set; }
        public decimal? QuantityRejected { get; set; }
        public decimal? OrderValue { get; set; }
        public decimal? UnitValue { get; set; }
        public bool? IsStockItem { get; set; }
        public decimal? Discount { get; set; }
        public string LineItemId { get; set; }
        public int? ProjectQnumber { get; set; }

        public virtual Item Item { get; set; }
        public virtual Order Order { get; set; }
    }
}
