using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class NewPlantLookup
    {
        public int PlantId { get; set; }
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
        public string CalibrationDate { get; set; }
        public string CalibrationDue { get; set; }
        public string Status { get; set; }
        public string PlantRate { get; set; }
        public int? IsHireVehicle { get; set; }
        public string OnHireDate { get; set; }
        public string OffHireDate { get; set; }
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
        public string HireReturnDueDate { get; set; }
        public string MaintAttributeStyle { get; set; }
        public string MaintLogBrief { get; set; }
        public string ScheduledServicingLog { get; set; }
        public int? AssetNumber { get; set; }
    }
}
