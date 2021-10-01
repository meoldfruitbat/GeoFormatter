using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class FaultMapLocation
    {
        public long Id { get; set; }
        public long FaultId { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string Location { get; set; }
    }
}
