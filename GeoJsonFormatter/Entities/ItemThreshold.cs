using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class ItemThreshold
    {
        public int Id { get; set; }
        public int? ItemGroupId { get; set; }
        public int? ItemTypeId { get; set; }
        public int PriceBreaksNo { get; set; }

        public virtual ItemGroup ItemGroup { get; set; }
        public virtual ItemType ItemType { get; set; }
    }
}
