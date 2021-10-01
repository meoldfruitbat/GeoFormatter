using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class PriceEnquiryItemType
    {
        public int Id { get; set; }
        public int PriceEnquiryId { get; set; }
        public int ItemTypeId { get; set; }

        public virtual ItemType ItemType { get; set; }
        public virtual PriceEnquiry PriceEnquiry { get; set; }
    }
}
