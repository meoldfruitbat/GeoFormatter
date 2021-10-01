using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class PlantDoc
    {
        public Guid Id { get; set; }
        public long Ticket { get; set; }
        public short ItemNo { get; set; }
        public string FileName { get; set; }
    }
}
