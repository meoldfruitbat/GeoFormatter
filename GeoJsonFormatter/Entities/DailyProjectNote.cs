using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class DailyProjectNote
    {
        public long Id { get; set; }
        public long? ProjectTimeId { get; set; }
        public string Notes { get; set; }

        public virtual UserDailyProjectTime ProjectTime { get; set; }
    }
}
