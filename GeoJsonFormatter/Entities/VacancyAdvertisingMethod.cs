using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class VacancyAdvertisingMethod
    {
        public int Id { get; set; }
        public int AdvertiseId { get; set; }
        public string Method { get; set; }
        public decimal? EstimatedCost { get; set; }

        public virtual VacancyAdvertising Advertise { get; set; }
    }
}
