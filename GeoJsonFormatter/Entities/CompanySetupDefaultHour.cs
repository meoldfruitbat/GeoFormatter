using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class CompanySetupDefaultHour
    {
        public int Id { get; set; }
        public TimeSpan? MonToFriStartTime { get; set; }
        public TimeSpan? MonToFriEndTime { get; set; }
        public TimeSpan? SaturdayStartTime { get; set; }
        public TimeSpan? SaturdayEndTime { get; set; }
        public TimeSpan? SundayStartTime { get; set; }
        public TimeSpan? SundayEndTime { get; set; }
        public bool? MonToFriNa { get; set; }
        public bool? SaturdayNa { get; set; }
        public bool? SundayNa { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? ModifiedBy { get; set; }
    }
}
