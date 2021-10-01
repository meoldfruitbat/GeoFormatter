using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class TaskWeekendDetail
    {
        public int Id { get; set; }
        public long TaskId { get; set; }
        public bool IsSaturday { get; set; }
        public DateTime Date { get; set; }

        public virtual TaskDetail Task { get; set; }
    }
}
