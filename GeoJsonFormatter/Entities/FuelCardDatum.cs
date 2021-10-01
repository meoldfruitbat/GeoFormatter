using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class FuelCardDatum
    {
        public int Id { get; set; }
        public string CardNo { get; set; }
        public string CardType { get; set; }
        public string VehicleRegistration { get; set; }
        public string RegistrationGiven { get; set; }
        public string SiteName { get; set; }
        public string SitePostcode { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string ProductDescription { get; set; }
        public long? Milage { get; set; }
        public decimal? Volume { get; set; }
        public decimal? NetPrice { get; set; }
    }
}
