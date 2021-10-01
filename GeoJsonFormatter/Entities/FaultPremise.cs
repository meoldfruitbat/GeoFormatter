using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class FaultPremise
    {
        public int FaultPremiseId { get; set; }
        public long? FaultId { get; set; }
        public string PremiseName { get; set; }
    }
}
