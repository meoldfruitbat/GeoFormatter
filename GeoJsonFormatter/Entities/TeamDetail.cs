using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class TeamDetail
    {
        public TeamDetail()
        {
            TeamOperatives = new HashSet<TeamOperative>();
            TeamRegions = new HashSet<TeamRegion>();
            TeamRoles = new HashSet<TeamRole>();
            TeamTrades = new HashSet<TeamTrade>();
            TeamWorkStreams = new HashSet<TeamWorkStream>();
        }

        public int Id { get; set; }
        public string TeamName { get; set; }
        public bool AgeRetentionApplicable { get; set; }
        public decimal? RetentionPercentage { get; set; }
        public bool IsInsurance { get; set; }
        public string PublicLiabilityNo { get; set; }
        public DateTime? PublicLiabilityExpiryDate { get; set; }
        public string ProfIndemnityNo { get; set; }
        public DateTime? ProfIndemnityExpiryDate { get; set; }
        public string ContractorLiabilityInsNo { get; set; }
        public DateTime? ContractorLiabilityInsExpiryDate { get; set; }
        public string EmployersLiabilityInsNo { get; set; }
        public DateTime? EmployersLiabilityInsExpiryDate { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? Createdby { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public byte[] TimeStampGeneral { get; set; }
        public string TimeStampFinancial { get; set; }
        public string TimeStampTrade { get; set; }
        public string TimeStampRates { get; set; }
        public bool IsOtherInsurance { get; set; }

        public virtual ICollection<TeamOperative> TeamOperatives { get; set; }
        public virtual ICollection<TeamRegion> TeamRegions { get; set; }
        public virtual ICollection<TeamRole> TeamRoles { get; set; }
        public virtual ICollection<TeamTrade> TeamTrades { get; set; }
        public virtual ICollection<TeamWorkStream> TeamWorkStreams { get; set; }
    }
}
