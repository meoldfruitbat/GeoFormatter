using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class OperativeDeductionBenefit
    {
        public long Id { get; set; }
        public long? OperativeId { get; set; }
        public int? DeductionBenefitId { get; set; }
        public decimal? Amount { get; set; }
        public bool? SalaryInclusion { get; set; }
        public string DeductionOrBenefit { get; set; }
        public string DeductionOrBenefitName { get; set; }
        public DateTime? AddedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool? IsCustomized { get; set; }
        public long? AddedBy { get; set; }
        public string Frequency { get; set; }

        public virtual GenericValue DeductionBenefit { get; set; }
        public virtual OperativeFile Operative { get; set; }
    }
}
