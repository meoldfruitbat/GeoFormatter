using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class SdhMusReconciliationWorksDatum
    {
        public long Id { get; set; }
        public int? RecId { get; set; }
        public string Musarea { get; set; }
        public string CostCode { get; set; }
        public string FinanceCode { get; set; }
        public string Exchange { get; set; }
        public string Pcpref { get; set; }
        public int? OrderId { get; set; }
        public string EstimateNo { get; set; }
        public string OrderType { get; set; }
        public string Status { get; set; }
        public DateTime? MonthDayYearofEngCompDate { get; set; }
        public string JobItemLink { get; set; }
        public string ItemCode { get; set; }
        public string Subbie { get; set; }
        public int? PlannedQuantity { get; set; }
        public int? CompletedQuantity { get; set; }
        public int? OutstandingQuantity { get; set; }
        public decimal? SubconItemRate { get; set; }
        public decimal? PlannedSubconValue { get; set; }
        public decimal? CompletedSubconValue { get; set; }
        public decimal? OutstandingSubconValue { get; set; }

        public virtual SdhMusReconciliationSummary Rec { get; set; }
    }
}
