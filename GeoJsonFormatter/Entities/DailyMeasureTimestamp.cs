using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class DailyMeasureTimestamp
    {
        public int Id { get; set; }
        public long? GangId { get; set; }
        public long? ContractId { get; set; }
        public long? SupervisorId { get; set; }
        public DateTime? LabourDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Timestamp { get; set; }
    }
}
