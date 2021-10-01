using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class SdhMusReconciliationDefect
    {
        public long Id { get; set; }
        public int? RecId { get; set; }
        public string ChargeRef { get; set; }
        public string OrderReference { get; set; }
        public string Estimate { get; set; }
        public string ContractNumber { get; set; }
        public string RegionName { get; set; }
        public string NoticeRef { get; set; }
        public string LaReference { get; set; }
        public string ChargeType { get; set; }
        public string InspectionRef { get; set; }
        public string DefectType { get; set; }
        public string Priority { get; set; }
        public string InspectionType { get; set; }
        public decimal? DefectRecieved { get; set; }
        public string AcceptanceStatus { get; set; }
        public string OriginalContractor { get; set; }
        public string InspectionComments { get; set; }
        public decimal? DefectChargeValue { get; set; }
        public decimal? BtdefectAdminFee { get; set; }
        public decimal? TotalDefectCharge { get; set; }

        public virtual SdhMusReconciliationSummary Rec { get; set; }
    }
}
