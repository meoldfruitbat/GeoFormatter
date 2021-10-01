using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class Timing
    {
        public Guid Id { get; set; }
        public Guid TimeSheetId { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime? StopDateTime { get; set; }
        public string Comments { get; set; }
        public byte[] TimeInserted { get; set; }
    }
}
