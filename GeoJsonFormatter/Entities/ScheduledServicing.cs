using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class ScheduledServicing
    {
        public long Id { get; set; }
        public long PlantId { get; set; }
        public string PlantLocation { get; set; }
        public string Comments { get; set; }
        public long PlantOwner { get; set; }
        public string Status { get; set; }
        public DateTime DateSubmitted { get; set; }
        public DateTime? DateCompleted { get; set; }
        public string Type { get; set; }
        public DateTime DueDate { get; set; }
        public Guid? PlantMaintenanceCommentsId { get; set; }
        public string CertificateType { get; set; }
    }
}
