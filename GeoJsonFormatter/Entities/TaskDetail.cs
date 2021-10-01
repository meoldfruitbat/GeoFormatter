using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class TaskDetail
    {
        public TaskDetail()
        {
            TaskWeekendDetails = new HashSet<TaskWeekendDetail>();
        }

        public long Id { get; set; }
        public long? ParentTaskId { get; set; }
        public string TaskCode { get; set; }
        public string TaskName { get; set; }
        public string Role { get; set; }
        public DateTime StartDate { get; set; }
        public bool IsStartMilestone { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsEndMilestone { get; set; }
        public int Duration { get; set; }
        public decimal? Progress { get; set; }
        public string Dependency { get; set; }
        public long ProjectId { get; set; }
        public int? TeamId { get; set; }
        public bool HasChild { get; set; }
        public int TaskLevel { get; set; }
        public int TaskRowIndex { get; set; }
        public bool IsCriticalTask { get; set; }
        public string TaskDescription { get; set; }
        public bool IsSaturdayWorking { get; set; }
        public bool IsSundayWorking { get; set; }
        public bool IsHolidayWorking { get; set; }
        public bool IsNightWork { get; set; }
        public long? SupervisorId { get; set; }
        public long? LoneOperativeId { get; set; }
        public long? SeniorSupervisorId { get; set; }
        public short? TeamType { get; set; }

        public virtual ICollection<TaskWeekendDetail> TaskWeekendDetails { get; set; }
    }
}
