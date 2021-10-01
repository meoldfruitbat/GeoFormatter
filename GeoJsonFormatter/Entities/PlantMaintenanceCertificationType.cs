using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class PlantMaintenanceCertificationType
    {
        public Guid Id { get; set; }
        public string PlantGroup { get; set; }
        public string PlantType { get; set; }
        public string ServiceType1 { get; set; }
        public string ServiceType2 { get; set; }
        public string ServiceType3 { get; set; }
        public string CertificationRequired { get; set; }
    }
}
