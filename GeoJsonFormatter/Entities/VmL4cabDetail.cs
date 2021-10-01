using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class VmL4cabDetail
    {
        public long Id { get; set; }
        public int? Vmnbunumber { get; set; }
        public string L4number { get; set; }
        public string CabinetDetails { get; set; }
        public string Location { get; set; }
        public string Existing { get; set; }
        public int? HomesServed { get; set; }
        public string UcNc { get; set; }
        public string PreSitedById { get; set; }
        public string PreSiteStatus { get; set; }
        public DateTime? LastUpdateTime { get; set; }
        public bool IsCivilsCompleted { get; set; }
        public long? QuoteId { get; set; }
        public string CityFibreRef { get; set; }
    }
}
