using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class PlantChecksForScdstore
    {
        public Guid Id { get; set; }
        public long PlantTransferControlId { get; set; }
        public long PlantId { get; set; }
        public int CheckIndex { get; set; }
        public string Response { get; set; }
        public DateTime DateTimeOfCheck { get; set; }
        public string CheckedBy { get; set; }
    }
}
