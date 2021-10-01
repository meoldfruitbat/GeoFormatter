using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class FibreTestResult
    {
        public int Id { get; set; }
        public string ExchangeCode { get; set; }
        public string Asuite { get; set; }
        public string Arack { get; set; }
        public long? Aposition { get; set; }
        public decimal? AttenuationAb1310nm { get; set; }
        public decimal? AttenuationAb1550nm { get; set; }
        public string CustomerName { get; set; }
        public string Bsuite { get; set; }
        public string Brack { get; set; }
        public string Bposition { get; set; }
        public decimal? AttenuationBa1310nm { get; set; }
        public decimal? AttenuationBa1550nm { get; set; }
        public decimal? AverageAttenuation1310nm { get; set; }
        public decimal? AverageAttenuation1550nm { get; set; }
        public long? TotalSplicesAb { get; set; }
        public decimal? DistanceAb { get; set; }
        public DateTime? TestDate { get; set; }
        public long? TesterId { get; set; }
        public string Identifier { get; set; }
        public bool TestPassed { get; set; }
        public long? QuoteId { get; set; }
        public decimal? Ilmaab1310 { get; set; }
        public decimal? Ilmaba1310 { get; set; }
        public decimal? Ilmaab1550 { get; set; }
        public decimal? Ilmaba1550 { get; set; }
        public decimal? AverageIlmaab1310 { get; set; }
        public decimal? AverageIlmaab1550 { get; set; }
    }
}
