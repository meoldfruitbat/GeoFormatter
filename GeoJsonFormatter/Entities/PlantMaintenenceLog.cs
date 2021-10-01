using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class PlantMaintenenceLog
    {
        public long MaintLogId { get; set; }
        public string PlantId { get; set; }
        public string TestType { get; set; }
        public DateTime? TestDate { get; set; }
        public string AttributeGroupName { get; set; }
        public string RepairData { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public decimal? CostOfAnySpares { get; set; }
        public string DamageIndicator { get; set; }
        public long? Ticket { get; set; }
    }
}
