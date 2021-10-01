using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Entities
{
    public partial class VmnetworkExpansionReleaseDatum
    {
        public long Id { get; set; }
        public int? Vmnbunumber { get; set; }
        public string L4number { get; set; }
        public string PlotNumber { get; set; }
        public string Uprn { get; set; }
        public string BusinessName { get; set; }
        public string BuildingNumber { get; set; }
        public string BuildingName { get; set; }
        public string StreetName { get; set; }
        public string TownCity { get; set; }
        public string Postcode { get; set; }
        public string DnaaddressType { get; set; }
        public string BuildingStandard { get; set; }
        public string L4cab { get; set; }
        public string L5cab { get; set; }
        public string CatvBb { get; set; }
        public string Telco { get; set; }
        public string ReleasedBy { get; set; }
        public DateTime? ReleasedDate { get; set; }
        public string Comments { get; set; }
        public string DropLength { get; set; }
        public string PressureTested { get; set; }
        public string Calibrated { get; set; }
        public decimal? TobyLength { get; set; }
        public decimal? TobyWidth { get; set; }
        public decimal? DuctLabel { get; set; }
        public DateTime? DateofTest { get; set; }
        public Guid? ClaimId { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? Blocked { get; set; }
        public long? QuoteId { get; set; }
        public string CityFibreRef { get; set; }
        public decimal? SnToTobyLen { get; set; }
        public decimal? PnToTobyLen { get; set; }
        public decimal? TobyToPremLen { get; set; }
        public string DpGisId { get; set; }
        public string CpGisId { get; set; }
        public bool? SavedToServer { get; set; }
        public decimal? Depth { get; set; }
        public string SurfaceType { get; set; }
    }
}
