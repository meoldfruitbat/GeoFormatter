using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class HolidayPlannerView
    {
        public HolidayPlannerView()
        {
            PlannerViewOperatives = new HashSet<PlannerViewOperative>();
        }

        public int Id { get; set; }
        public string PlannerName { get; set; }
        public DateTime? CreatedOn { get; set; }
        public long? CreatedBy { get; set; }
        public bool IsGlobal { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? ModifiedDateTime { get; set; }
        public long? DeletedBy { get; set; }

        public virtual ICollection<PlannerViewOperative> PlannerViewOperatives { get; set; }
    }
}
