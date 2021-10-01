using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class NextYearHoliday
    {
        public int Id { get; set; }
        public int NoOfBaseLeaves { get; set; }
        public int NoOfLeavesToBeIncremented { get; set; }
        public int NoOfYearsForLeavesToBeIncremented { get; set; }
        public int NoOfYearsForLeavesToBeFreezed { get; set; }
        public int Date { get; set; }
        public int Month { get; set; }
        public decimal NoOfYearsServiceRequiredForLeavesToBeIncremented { get; set; }
        public bool AddDayHolidayForBirthday { get; set; }
        public string SaturdayBirthdayUse { get; set; }
        public string SundayBirthdayUse { get; set; }
    }
}
