using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class ClaimedFile
    {
        public long ClaimId { get; set; }
        public string ContractReference { get; set; }
        public string QuoteId { get; set; }
        public string ContractId { get; set; }
        public string SynCode { get; set; }
        public string ConPrefix { get; set; }
        public string ClaimSupervisor { get; set; }
        public string ClaimGang { get; set; }
        public string ClaimType { get; set; }
        public string IsVariation { get; set; }
        public string ClaimHeader { get; set; }
        public string ClaimDesc { get; set; }
        public decimal? ClaimQty { get; set; }
        public string BaseUnit { get; set; }
        public decimal? ClaimRate01 { get; set; }
        public decimal? ClaimRate02 { get; set; }
        public string ClaimPrefix { get; set; }
        public DateTime? ClaimDate { get; set; }
        public string ToDoBeforeClaim { get; set; }
        public DateTime? PostedByGanger { get; set; }
        public DateTime? ApprovedBySupervisor { get; set; }
        public string SupervisorChanges { get; set; }
        public string PostedByGangerName { get; set; }
        public string ApprovedBySupervisorName { get; set; }
        public DateTime? PostedByAdmin { get; set; }
        public decimal? Labour { get; set; }
        public decimal? Plant { get; set; }
        public decimal? Materials { get; set; }
        public decimal? SubContract { get; set; }
        public string OriginalClaimQtyByGang { get; set; }
        public decimal? GangLabour { get; set; }
        public decimal? GangPlant { get; set; }
        public decimal? GangMaterials { get; set; }
        public decimal? GrabLabour { get; set; }
        public decimal? GrabPlant { get; set; }
        public decimal? GrabMaterials { get; set; }
        public decimal? BoxBuilderLabour { get; set; }
        public decimal? BoxBuilderPlant { get; set; }
        public decimal? BoxBuilderMaterials { get; set; }
        public decimal? ReinstatingLabour { get; set; }
        public decimal? ReinstatingPlant { get; set; }
        public decimal? ReinstatingMaterials { get; set; }
        public decimal? CableGangLabour { get; set; }
        public decimal? CableGangPlant { get; set; }
        public decimal? CableGangMaterials { get; set; }
        public decimal? FibreGangLabour { get; set; }
        public decimal? FibreGangPlant { get; set; }
        public decimal? FibreGangMaterials { get; set; }
        public decimal? Tmchapter8 { get; set; }
        public decimal? RiskAndBalancingItem { get; set; }
        public decimal? SubbyLabourOnly { get; set; }
        public decimal? SubbyLabourAndPlant { get; set; }
        public decimal? ClaimWidth { get; set; }
        public string TobyPicture { get; set; }
        public string TrackPicture { get; set; }
        public string TobyMeasure { get; set; }
        public Guid? ClaimId1 { get; set; }
        public decimal? ClaimDepth { get; set; }
    }
}
