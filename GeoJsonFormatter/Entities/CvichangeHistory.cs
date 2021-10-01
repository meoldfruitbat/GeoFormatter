using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class CvichangeHistory
    {
        public long Id { get; set; }
        public string Comments { get; set; }
        public double? Price { get; set; }
        public long Cvino { get; set; }
        public DateTime DateSubmitted { get; set; }
        public string ChangeMadeBy { get; set; }
    }
}
