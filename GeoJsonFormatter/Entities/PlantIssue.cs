using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class PlantIssue
    {
        public long Id { get; set; }
        public long PlantId { get; set; }
        public string FirstQuestion { get; set; }
        public string SecondQuestion { get; set; }
        public string PlantLocation { get; set; }
        public string Comments { get; set; }
        public string IssueReportedBy { get; set; }
        public string PlantOwner { get; set; }
        public string Picture1 { get; set; }
        public string Picture2 { get; set; }
        public string Picture3 { get; set; }
        public string Picture4 { get; set; }
        public string Status { get; set; }
        public DateTime DateSubmitted { get; set; }
        public string Confirmation { get; set; }
        public DateTime? DateCompleted { get; set; }
        public Guid? PlantMaintenanceCommentsId { get; set; }
    }
}
