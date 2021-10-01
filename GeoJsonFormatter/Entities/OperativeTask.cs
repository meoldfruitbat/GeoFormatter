using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class OperativeTask
    {
        public int Id { get; set; }
        public long OperativeId { get; set; }
        public int StatusId { get; set; }
        public DateTime DateLogged { get; set; }
        public string TaskTitle { get; set; }
        public string TaskDescription { get; set; }
        public string TaskCancelledReason { get; set; }
        public string TaskType { get; set; }
        public bool TaskViewOnly { get; set; }
        public int TaskId { get; set; }
        public int? InputById { get; set; }
        public DateTime? InputOn { get; set; }

        public virtual OperativeFile Operative { get; set; }
        public virtual OperativeTaskStatus Status { get; set; }
    }
}
