using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class PublicUtilityDamageWitness
    {
        public int Id { get; set; }
        public long PublicUtilityDamageId { get; set; }
        public string Name { get; set; }
        public string ContactNumber { get; set; }
        public string Comment { get; set; }
        public DateTime StatementDate { get; set; }
        public int? InvestigationId { get; set; }
        public DateTime? InputOn { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string SignatureFileName { get; set; }
        public bool? IsHandWritten { get; set; }
        public bool? IsFinal { get; set; }

        public virtual PublicUtilityDamage PublicUtilityDamage { get; set; }
    }
}
