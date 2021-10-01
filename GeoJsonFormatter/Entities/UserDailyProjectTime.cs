using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class UserDailyProjectTime
    {
        public UserDailyProjectTime()
        {
            DailyProjectNotes = new HashSet<DailyProjectNote>();
        }

        public long ProjectTimeId { get; set; }
        public long? DailyTimeId { get; set; }
        public long? UserId { get; set; }
        public int? QuoteId { get; set; }
        public TimeSpan? StartTime { get; set; }
        public TimeSpan? Endtime { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public long? LastModifiedBy { get; set; }
        public DateTime? LastModifiedOn { get; set; }

        public virtual UserDailyTime DailyTime { get; set; }
        public virtual ICollection<DailyProjectNote> DailyProjectNotes { get; set; }
    }
}
