using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class NonConformanceActionTask
    {
        public int Id { get; set; }
        public int? NonConformanceId { get; set; }
        public string DepartmentId { get; set; }
        public long? AssignTo { get; set; }
        public string Name { get; set; }
        public string Requirements { get; set; }
        public DateTime? RequiredByDate { get; set; }
        public string ActionType { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string EventId { get; set; }
        public int? GroupId { get; set; }
        public bool IsCompleted { get; set; }

        public virtual OperativeFile AssignToNavigation { get; set; }
        public virtual DepartmentFile Department { get; set; }
        public virtual OperativeGroup1 Group { get; set; }
        public virtual NonConformanceDetail NonConformance { get; set; }
    }
}
