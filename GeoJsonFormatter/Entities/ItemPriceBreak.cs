using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class ItemPriceBreak
    {
        public int Id { get; set; }
        public int ThresholdId { get; set; }
        public decimal Value { get; set; }
    }
}
