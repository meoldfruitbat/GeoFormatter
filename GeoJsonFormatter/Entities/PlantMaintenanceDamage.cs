using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class PlantMaintenanceDamage
    {
        public Guid Id { get; set; }
        public long Ticket { get; set; }
        public short ItemNo { get; set; }
        public string Description { get; set; }
        public bool AccidentalDamage { get; set; }
        public bool MaliciousDamage { get; set; }
        public DateTime DamageReportDate { get; set; }
        public bool SendEmailNotification { get; set; }
    }
}
