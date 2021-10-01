using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class PlantMaintScheduledServiceType
    {
        public long Id { get; set; }
        public string FullDescription { get; set; }
        public string DevelopmentDescription { get; set; }
        public string AbbreviatedDescription { get; set; }
        public string Active { get; set; }
    }
}
