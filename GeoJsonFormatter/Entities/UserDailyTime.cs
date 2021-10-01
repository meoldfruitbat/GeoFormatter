using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class UserDailyTime
    {
        public UserDailyTime()
        {
            UserDailyProjectTimes = new HashSet<UserDailyProjectTime>();
            UserDailyTimeNotes = new HashSet<UserDailyTimeNote>();
        }

        public long DailyTimeId { get; set; }
        public long? UserId { get; set; }
        public DateTime? Date { get; set; }
        public bool IsNightShift { get; set; }
        public bool IsApproved { get; set; }
        public TimeSpan? InTime { get; set; }
        public TimeSpan? OutTime { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public long? LastModifiedBy { get; set; }
        public DateTime LastModifiedOn { get; set; }
        public bool IsSubmited { get; set; }
        public byte[] Timestamp { get; set; }

        public virtual ICollection<UserDailyProjectTime> UserDailyProjectTimes { get; set; }
        public virtual ICollection<UserDailyTimeNote> UserDailyTimeNotes { get; set; }
    }
}
