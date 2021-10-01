using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class GenericValue
    {
        public GenericValue()
        {
            EnquiryTaskStatuses = new HashSet<EnquiryTaskStatus>();
            OperativeDeductionBenefits = new HashSet<OperativeDeductionBenefit>();
        }

        public int Id { get; set; }
        public string TypeName { get; set; }
        public string Value { get; set; }

        public virtual ICollection<EnquiryTaskStatus> EnquiryTaskStatuses { get; set; }
        public virtual ICollection<OperativeDeductionBenefit> OperativeDeductionBenefits { get; set; }
    }
}
