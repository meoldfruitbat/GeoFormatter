using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class SupSiteSafetyInspLog
    {
        public long Id { get; set; }
        public string ContractNumber { get; set; }
        public string ContractId { get; set; }
        public string ContractName { get; set; }
        public string TeamLeader { get; set; }
        public string Auditor { get; set; }
        public DateTime? LoggedDate { get; set; }
        public string LoggedBy { get; set; }
        public string ToolboxTalkDetails { get; set; }
        public string GeneralComments { get; set; }
        public string Status { get; set; }
        public string ReviewedBy { get; set; }
        public string ClearedBy { get; set; }
    }
}
