using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class NationalMinimumWage
    {
        public int Id { get; set; }
        public decimal Current25Above { get; set; }
        public decimal Future25Above { get; set; }
        public decimal Current21To24 { get; set; }
        public decimal Future21To24 { get; set; }
        public decimal Current18To20 { get; set; }
        public decimal Future18To20 { get; set; }
        public decimal CurrentU18 { get; set; }
        public decimal FutureU18 { get; set; }
        public decimal CurrentApprentice { get; set; }
        public decimal FutureApprentice { get; set; }
        public DateTime FutureChangeDate { get; set; }
    }
}
