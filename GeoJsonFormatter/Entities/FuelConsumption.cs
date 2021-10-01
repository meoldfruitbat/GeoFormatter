using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class FuelConsumption
    {
        public int Id { get; set; }
        public DateTime DateOfEntry { get; set; }
        public string FullName { get; set; }
        public string RegAssetNumber { get; set; }
        public string Type { get; set; }
        public decimal? HoursOrMilage { get; set; }
        public decimal? StartReading { get; set; }
        public decimal? Qty { get; set; }
        public decimal? EndReading { get; set; }
    }
}
