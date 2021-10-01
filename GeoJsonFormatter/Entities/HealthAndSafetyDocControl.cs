using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class HealthAndSafetyDocControl
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Filename { get; set; }
        public string Type { get; set; }
        public decimal? Version { get; set; }
        public string Categories { get; set; }
        public string Active { get; set; }
    }
}
