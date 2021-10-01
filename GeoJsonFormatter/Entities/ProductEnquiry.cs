using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class ProductEnquiry
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public string Size { get; set; }
        public decimal? Quantity { get; set; }
        public string Description { get; set; }
        public string Specification { get; set; }
        public int? PriceEnquirySupplierId { get; set; }
        public decimal? Rate { get; set; }
        public decimal? Discount { get; set; }
        public decimal? Net { get; set; }
        public decimal? MinOrderQuantity { get; set; }
        public int? Rank { get; set; }
        public string Status { get; set; }

        public virtual Item Item { get; set; }
        public virtual PriceEnquirySupplier PriceEnquirySupplier { get; set; }
    }
}
