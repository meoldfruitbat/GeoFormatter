using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class DepartmentFile
    {
        public DepartmentFile()
        {
            CustomerEnquiryActionTasks = new HashSet<CustomerEnquiryActionTask>();
            NonConformanceActionTasks = new HashSet<NonConformanceActionTask>();
        }

        public string IdCode { get; set; }
        public string Department { get; set; }
        public string Description { get; set; }
        public int? MarkActive { get; set; }
        public int? MarkDeleted { get; set; }

        public virtual ICollection<CustomerEnquiryActionTask> CustomerEnquiryActionTasks { get; set; }
        public virtual ICollection<NonConformanceActionTask> NonConformanceActionTasks { get; set; }
    }
}
