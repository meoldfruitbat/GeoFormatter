using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class StockFuel
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public decimal StartReading { get; set; }
        public decimal EndReading { get; set; }
        public decimal? TotalLitres { get; set; }
        public int Qnumber { get; set; }
        public int? RecievedBy { get; set; }
        public string ImageFileName { get; set; }
        public string SignatureFileName { get; set; }
        public DateTime? DateTimeOfDelivery { get; set; }
    }
}
