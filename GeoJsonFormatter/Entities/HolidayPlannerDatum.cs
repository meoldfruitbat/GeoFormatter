using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class HolidayPlannerDatum
    {
        public long Id { get; set; }
        public string ForeName { get; set; }
        public string Surname { get; set; }
        public string Month { get; set; }
        public string Year { get; set; }
        public string HolidayString { get; set; }
        public string Comments { get; set; }
        public string Category { get; set; }
        public string Confirmed { get; set; }
        public string Authorised { get; set; }
        public DateTime? DateTimeHolidayRequested { get; set; }
        public long? OperativeId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string LeaveType { get; set; }
        public string LeaveFor { get; set; }
        public string LeaveComment { get; set; }
    }
}
