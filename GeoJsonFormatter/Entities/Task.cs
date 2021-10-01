using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class Task
    {
        public long Id { get; set; }
        public long? OwnerId { get; set; }
        public long? LeadId { get; set; }
        public long? CompanyId { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public long? RegardingId { get; set; }
        public string Duration { get; set; }
        public DateTime DateEntered { get; set; }
        public string Status { get; set; }
        public DateTime DateLastModified { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Priority { get; set; }
        public int TotalTimeWorked { get; set; }
        public DateTime? ReminderDate { get; set; }
    }
}
