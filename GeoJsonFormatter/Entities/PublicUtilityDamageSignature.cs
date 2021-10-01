using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class PublicUtilityDamageSignature
    {
        public PublicUtilityDamageSignature()
        {
            PublicUtilityDamageInvestigations = new HashSet<PublicUtilityDamageInvestigation>();
        }

        public int Id { get; set; }
        public long PublicUtilityDamageId { get; set; }
        public string SignatureType { get; set; }
        public string Filename { get; set; }
        public DateTime SignatureDate { get; set; }
        public int? InvestigationId { get; set; }
        public long? UserId { get; set; }

        public virtual PublicUtilityDamage PublicUtilityDamage { get; set; }
        public virtual ICollection<PublicUtilityDamageInvestigation> PublicUtilityDamageInvestigations { get; set; }
    }
}
