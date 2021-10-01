using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class PlantCheckControl
    {
        public long Id { get; set; }
        public long DailyPlantChecksDetailId { get; set; }
        public DateTime LoggedDate { get; set; }
        public string Status { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? CompletionDate { get; set; }
        public string ProjectName { get; set; }
        public Guid? PlantMaintenanceCommentsId { get; set; }
    }
}
