using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class CompanySetupWorkingHour
    {
        public int Id { get; set; }
        public string WorkingDays { get; set; }
        public DateTime? StartHours { get; set; }
        public DateTime? EndHours { get; set; }
        public decimal? HoursFactor { get; set; }
        public DateTime? TravelTimeHours { get; set; }
        public decimal? TravelFactor { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? ModifiedBy { get; set; }
    }
}
