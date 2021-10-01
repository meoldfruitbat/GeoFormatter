using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class Rate
    {
        public long Id { get; set; }
        public string WorkHeader { get; set; }
        public string WorkDescription { get; set; }
        public string BaseUnit { get; set; }
        public decimal? WorkRate { get; set; }
        public string ClientWorkDescription { get; set; }
        public string ClientWorkItem { get; set; }
        public string Category { get; set; }
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
        public string BaseContractId { get; set; }
        public decimal? Labour { get; set; }
        public decimal? Plant { get; set; }
        public decimal? Materials { get; set; }
        public decimal? Subcontract { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsDetailed { get; set; }
        public byte[] Timestamp { get; set; }
        public string TermContract { get; set; }
        public decimal? SubbyMethod3 { get; set; }
        public int? WorkType { get; set; }
        public int? WorkStream { get; set; }
        public int? WorkCategoryId { get; set; }
    }
}
