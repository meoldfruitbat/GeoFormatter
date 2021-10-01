using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class UserDailyTimeNote
    {
        public long Id { get; set; }
        public long? DailyTimeId { get; set; }
        public string Notes { get; set; }

        public virtual UserDailyTime DailyTime { get; set; }
    }
}
