using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class DeliveryCost
    {
        public long Id { get; set; }
        public string CompanyId { get; set; }
        public string CompanyName { get; set; }
        public decimal? DeliveryCharge { get; set; }
        public string AnyNotes { get; set; }
    }
}
