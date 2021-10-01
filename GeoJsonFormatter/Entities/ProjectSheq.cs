using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class ProjectSheq
    {
        public long Id { get; set; }
        public long MainContractId { get; set; }
        public string Name { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string PostCode { get; set; }
        public string Summary { get; set; }
        public short? RequireRams { get; set; }
        public bool? IsNotifiableUnderCmd { get; set; }
        public bool? IsSubjectToQualityAudit { get; set; }
        public long? PrimaryResponsible { get; set; }
        public long? SecondaryResponsible { get; set; }

        public virtual ContractFile MainContract { get; set; }
    }
}
