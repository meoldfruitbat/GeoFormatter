using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class OperativesCosting
    {
        public long Id { get; set; }
        public string WorkingDays { get; set; }
        public string StatDaysPerYear { get; set; }
        public string Nhipercent { get; set; }
        public string Nhiweek { get; set; }
        public string NhiworkingDays { get; set; }
        public string Insurances { get; set; }
        public string HolidayAndSickPay { get; set; }
        public string Workwear { get; set; }
        public string SmallTools { get; set; }
        public string TrainingDays { get; set; }
        public string TrainingAmount { get; set; }
        public string MobilePhonePerMonth { get; set; }
        public string MobileCallsPerMonth { get; set; }
        public string WorkingWeeks { get; set; }
        public string WorkingHoursInWeek { get; set; }
        public string BasicHourlyRate { get; set; }
        public string Overtime { get; set; }
        public string CostingGroup { get; set; }
        public string Rate { get; set; }
        public string WorkingHoursInDay { get; set; }
        public string TotalHourlyRate { get; set; }
    }
}
