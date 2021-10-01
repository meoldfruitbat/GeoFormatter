using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class ContractorPartnerDetail
    {
        public long Id { get; set; }
        public long ContractorId { get; set; }
        public string PartnerFirstName { get; set; }
        public string PartnerSurName { get; set; }
        public string PartnerTitle { get; set; }

        public virtual ClientContractorFile Contractor { get; set; }
    }
}
