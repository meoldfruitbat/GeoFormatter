using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class FaultEscalation
    {
        public long FaultEscalationId { get; set; }
        public long FaultId { get; set; }
        public long ClientId { get; set; }
        public string Details { get; set; }
        public int? Stage { get; set; }
        public DateTime? AddedOn { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public byte[] Timestamp { get; set; }
    }
}
