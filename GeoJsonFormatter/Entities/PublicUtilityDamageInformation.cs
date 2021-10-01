using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class PublicUtilityDamageInformation
    {
        public long Infold { get; set; }
        public long? PublicUtilityDamageId { get; set; }
        public long? InvestigationId { get; set; }
        public DateTime? InputOn { get; set; }
        public bool? DamagedUtilityPrintsProvided { get; set; }
        public bool? PrintsAdequateInformation { get; set; }
        public bool? PrintsColour { get; set; }
        public bool? ElectricPrintsProvided { get; set; }
        public bool? GasPrintsProvided { get; set; }
        public bool? WaterPrintsProvided { get; set; }
        public bool? BtprintsProvided { get; set; }
        public bool? SewerPrintsProvided { get; set; }
        public bool? CctvprintsProvided { get; set; }
        public bool? IsFinal { get; set; }
    }
}
