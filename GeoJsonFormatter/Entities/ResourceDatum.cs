using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class ResourceDatum
    {
        public long Id { get; set; }
        public long JobId { get; set; }
        public long GangOperativesId { get; set; }
        public long GangId { get; set; }
        public long GangLeaderId { get; set; }
        public long? Status { get; set; }
    }
}
