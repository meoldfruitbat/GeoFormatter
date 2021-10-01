using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class PlannerViewOperative
    {
        public int Id { get; set; }
        public int PlannerId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public long? CreatedBy { get; set; }
        public int? GroupId { get; set; }
        public int? ElementId { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? ModifiedDateTime { get; set; }
        public long? DeletedBy { get; set; }

        public virtual HolidayPlannerView Planner { get; set; }
    }
}
