using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class JobCentreTask
    {
        public Guid Id { get; set; }
        public Guid JobCentreCalendarId { get; set; }
        public Guid? TimeSheetId { get; set; }
        public int Status { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Summary { get; set; }
    }
}
