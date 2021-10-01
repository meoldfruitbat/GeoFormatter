using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class VmspecialReportCheck
    {
        public long CheckId { get; set; }
        public string ContractReference { get; set; }
        public string GangLeaderId { get; set; }
        public DateTime? Date { get; set; }
        public string IsItChecked { get; set; }
    }
}
