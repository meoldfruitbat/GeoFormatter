using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class ProjectLabourRequirement
    {
        public int Id { get; set; }
        public long MainContractId { get; set; }
        public int LabourRequirementNo { get; set; }
        public int LabourRequirementId { get; set; }

        public virtual ContractFile MainContract { get; set; }
    }
}
