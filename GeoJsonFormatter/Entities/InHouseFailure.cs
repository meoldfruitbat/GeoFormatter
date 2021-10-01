using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class InHouseFailure
    {
        public long Id { get; set; }
        public long PlantId { get; set; }
        public string Comments { get; set; }
        public string IssueReportedBy { get; set; }
        public string Status { get; set; }
        public DateTime DateSubmitted { get; set; }
        public DateTime? DateCompleted { get; set; }
        public Guid? PlantMaintenanceCommentsId { get; set; }
    }
}
