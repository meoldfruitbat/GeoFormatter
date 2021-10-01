using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class PlantLookup
    {
        public PlantLookup()
        {
            PlantRequisitionDetails = new HashSet<PlantRequisitionDetail>();
        }

        public long PlantId { get; set; }
        public string PlantGroup { get; set; }
        public string PlantType { get; set; }
        public string PlantMark { get; set; }
        public string PlantRef { get; set; }
        public string PlantSupplier { get; set; }
        public string PlantDepot { get; set; }
        public string PlantMake { get; set; }
        public string PlantModel { get; set; }
        public string PlantSize { get; set; }
        public string PlantWeight { get; set; }
        public string PlantSerial { get; set; }
        public string PlantEngine { get; set; }
        public string PlantTyreSize { get; set; }
        public int? RequiresCalibration { get; set; }
        public string CalibrationDateDelete { get; set; }
        public string CalibrationDueDelete { get; set; }
        public string Status { get; set; }
        public string PlantRate { get; set; }
        public int? IsHireVehicle { get; set; }
        public string OnHireDateDelete { get; set; }
        public string OffHireDateDelete { get; set; }
        public string PlantLocation { get; set; }
        public decimal? DayRate { get; set; }
        public decimal? HourRate { get; set; }
        public string PlantAddress01 { get; set; }
        public string PlantAddress02 { get; set; }
        public string PlantAddress03 { get; set; }
        public string PlantAddress04 { get; set; }
        public string PlantFax { get; set; }
        public string PlantTel { get; set; }
        public string PlantEmail { get; set; }
        public string Comments { get; set; }
        public string HireReference { get; set; }
        public string WeightMeasurment { get; set; }
        public string PlantWebsite { get; set; }
        public string OffHireReference { get; set; }
        public string HireReturnDueDateDelete { get; set; }
        public string MaintAttributeStyle { get; set; }
        public string MaintLogBrief { get; set; }
        public string ScheduledServicingLog { get; set; }
        public int? AssetNumber { get; set; }
        public DateTime? OnHireDate { get; set; }
        public DateTime? OffHireDate { get; set; }
        public DateTime? CalibrationDate { get; set; }
        public DateTime? CalibrationDue { get; set; }
        public DateTime? HireReturnDueDate { get; set; }
        public string SafeWorkingLoad1 { get; set; }
        public string SafeWorkingLoad2 { get; set; }
        public string MaxTowingCapacity { get; set; }
        public DateTime? DatePurchased { get; set; }
        public decimal? DeliveryCost { get; set; }
        public decimal? WeeklyCost { get; set; }
        public decimal? PurchasePrice { get; set; }
        public decimal? EstAssetValue { get; set; }
        public int? DeprYr1 { get; set; }
        public int? DeprYr2 { get; set; }
        public int? DeprYr3 { get; set; }
        public int? DeprYr4 { get; set; }
        public int? DeprYr5 { get; set; }
        public bool InHouseFailure { get; set; }
        public string PayrollCodes { get; set; }
        public string Manager { get; set; }
        public string DirectOrAgency { get; set; }

        public virtual ICollection<PlantRequisitionDetail> PlantRequisitionDetails { get; set; }
    }
}
