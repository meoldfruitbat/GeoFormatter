using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class LabourFile
    {
        public long LabourId { get; set; }
        public string ContractReference { get; set; }
        public string QuoteId { get; set; }
        public string ConPrefix { get; set; }
        public string ContractId { get; set; }
        public string LabourSupervisor { get; set; }
        public string LabourGang { get; set; }
        public string LabourOperative { get; set; }
        public string LabourAddress { get; set; }
        public DateTime? LabourDate { get; set; }
        public DateTime? TravelToSite { get; set; }
        public DateTime? TimeOnSite { get; set; }
        public DateTime? TimeLeftSite { get; set; }
        public DateTime? TravelFromSite { get; set; }
        public DateTime? LabourTravel { get; set; }
        public DateTime? LabourWorked { get; set; }
        public string LabourTravelRate { get; set; }
        public string LabourWorkRate { get; set; }
        public DateTime? TrackerStart { get; set; }
        public DateTime? TrackerOnsite { get; set; }
        public DateTime? TrackerOffsite { get; set; }
        public DateTime? TrackerFinish { get; set; }
        public DateTime? TrackerTravel { get; set; }
        public DateTime? TrackerWorked { get; set; }
        public string LabourType { get; set; }
        public string LabourReason { get; set; }
        public DateTime? NormalHours { get; set; }
        public DateTime? TimeAndHalfHours { get; set; }
        public DateTime? DoubleTimeHours { get; set; }
        public decimal? Wages { get; set; }
        public DateTime? ClaimedYardStart { get; set; }
        public DateTime? ClaimedYardEnd { get; set; }
        public DateTime? TrackerYardStart { get; set; }
        public DateTime? TrackerYardEnd { get; set; }
        public DateTime? HoursWorked { get; set; }
        public DateTime? HoursTravel { get; set; }
        public string ModifyWages { get; set; }
        public string ClaimedorTracked { get; set; }
        public DateTime? ActualNormalHours { get; set; }
        public DateTime? ActualTimeAndHalfHours { get; set; }
        public DateTime? ActualDoubleHours { get; set; }
        public DateTime? ActualTravelHours { get; set; }
        public decimal? NormalTrueCost { get; set; }
        public decimal? MidweekTrueCost { get; set; }
        public decimal? SaturdayTrueCost { get; set; }
        public decimal? DoubleTimeTrueCost { get; set; }
        public decimal? WagesTrueCost { get; set; }
        public DateTime? PostedByGanger { get; set; }
        public DateTime? ApprovedBySupervisor { get; set; }
        public string PostedByGangerName { get; set; }
        public string ApprovedBySupervisorName { get; set; }
        public DateTime? PostedByAdmin { get; set; }
        public decimal? HoursDeductions { get; set; }
        public bool IsToUsePricework { get; set; }
        public decimal? PriceworkValue { get; set; }
        public decimal? PlantDeduction { get; set; }
        public decimal? TeamMemberDeduction { get; set; }
        public decimal? PriceworkDeductions { get; set; }
        public decimal? PriceworkModifyWages { get; set; }
        public decimal? PriceworkWages { get; set; }
        public string HoursDeductionNotes { get; set; }
        public string PriceworkDeductionNotes { get; set; }
        public string PayType { get; set; }
        public DateTime? SupervisorStart { get; set; }
        public DateTime? SupervisorYardStart { get; set; }
        public DateTime? SupervisorOnSite { get; set; }
        public DateTime? SupervisorOffSite { get; set; }
        public DateTime? SupervisorYardEnd { get; set; }
        public DateTime? SupervisorFinish { get; set; }
        public DateTime? SupervisorWorked { get; set; }
        public DateTime? SupervisorTravel { get; set; }
        public string SupervisorLabourType { get; set; }
        public Guid? LabourGuid { get; set; }
    }
}
