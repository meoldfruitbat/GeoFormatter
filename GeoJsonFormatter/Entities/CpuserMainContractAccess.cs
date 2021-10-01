using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class CpuserMainContractAccess
    {
        public long Id { get; set; }
        public long CploginId { get; set; }
        public string ContractId { get; set; }

        public virtual CpuserDetail Cplogin { get; set; }
    }
}
