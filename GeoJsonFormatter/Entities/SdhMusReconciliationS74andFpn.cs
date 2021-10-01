using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class SdhMusReconciliationS74andFpn
    {
        public long Id { get; set; }
        public int? RecId { get; set; }
        public string ChargeRef { get; set; }
        public int? OrderReference { get; set; }
        public string Estimate { get; set; }
        public string ContractNumber { get; set; }
        public string RegionName { get; set; }
        public string NoticeRef { get; set; }
        public string LaReference { get; set; }
        public string ChargeType { get; set; }
        public string OriginalContractor { get; set; }
        public string ChargeAllocatedContractor { get; set; }
        public string Acstatus { get; set; }
        public string Reason { get; set; }
        public string Comments { get; set; }
        public decimal? RechargeValue { get; set; }
        public decimal? BtadminFee { get; set; }
        public decimal? TotalCharge { get; set; }

        public virtual SdhMusReconciliationSummary Rec { get; set; }
    }
}
