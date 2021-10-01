using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class PublicUtilityDamageInvestigationTypeAnswer
    {
        public long Id { get; set; }
        public string DamageTypeId { get; set; }
        public string DamageLocation { get; set; }
        public string Answer1 { get; set; }
        public string Answer2 { get; set; }
        public string Answer3 { get; set; }
        public string Answer4 { get; set; }
        public int PublicUtilityDamageId { get; set; }
        public int InvestigationId { get; set; }
        public DateTime? InputOn { get; set; }
        public string SurfaceMaterial { get; set; }
        public bool? IsFinal { get; set; }
    }
}
