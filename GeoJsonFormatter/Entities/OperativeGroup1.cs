using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class OperativeGroup1
    {
        public OperativeGroup1()
        {
            CustomerEnquiryActionTasks = new HashSet<CustomerEnquiryActionTask>();
            NonConformanceActionTasks = new HashSet<NonConformanceActionTask>();
            NonConformanceCostActions = new HashSet<NonConformanceCostAction>();
            OperativeGroups = new HashSet<OperativeGroup>();
            UtilityStrikeActionTasks = new HashSet<UtilityStrikeActionTask>();
        }

        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public int GrpLevel { get; set; }
        public int Position { get; set; }
        public bool IsPrevent { get; set; }

        public virtual ICollection<CustomerEnquiryActionTask> CustomerEnquiryActionTasks { get; set; }
        public virtual ICollection<NonConformanceActionTask> NonConformanceActionTasks { get; set; }
        public virtual ICollection<NonConformanceCostAction> NonConformanceCostActions { get; set; }
        public virtual ICollection<OperativeGroup> OperativeGroups { get; set; }
        public virtual ICollection<UtilityStrikeActionTask> UtilityStrikeActionTasks { get; set; }
    }
}
