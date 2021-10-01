using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class NonConformanceCostAction
    {
        public int Id { get; set; }
        public int? NonConformanceId { get; set; }
        public long? AssignTo { get; set; }
        public string Requirements { get; set; }
        public DateTime? RequiredByDate { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string Name { get; set; }
        public int? GroupId { get; set; }

        public virtual OperativeFile AssignToNavigation { get; set; }
        public virtual OperativeGroup1 Group { get; set; }
        public virtual NonConformanceDetail NonConformance { get; set; }
    }
}
