using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class PublicUtilityOtherPersonInvolved
    {
        public long Id { get; set; }
        public string ContractReference { get; set; }
        public DateTime? DateLogged { get; set; }
        public string Forename { get; set; }
        public string Surname { get; set; }
        public string Organisation { get; set; }
        public string VehicleReg { get; set; }
        public string Reason4visit { get; set; }
        public string Comments { get; set; }
        public DateTime? OnSiteTime { get; set; }
        public DateTime? OffSiteTime { get; set; }
        public DateTime? CreationDate { get; set; }
        public long? PublicUtilityDamageId { get; set; }
        public int? InvestigationId { get; set; }
        public DateTime? InputOn { get; set; }
        public bool? IsFinal { get; set; }

        public virtual PublicUtilityDamage PublicUtilityDamage { get; set; }
    }
}
