using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class CpuserDetail
    {
        public CpuserDetail()
        {
            CpuserAuthProvidersDetails = new HashSet<CpuserAuthProvidersDetail>();
            CpuserMainContractAccesses = new HashSet<CpuserMainContractAccess>();
        }

        public long Id { get; set; }
        public string LoginId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsAccessHome { get; set; }
        public bool IsAccessPreSiteSurvey { get; set; }
        public bool IsAccessSiteImages { get; set; }
        public bool IsAccessHealthAndSafety { get; set; }
        public bool IsAccessDfes { get; set; }
        public bool IsEnableUser { get; set; }

        public virtual ICollection<CpuserAuthProvidersDetail> CpuserAuthProvidersDetails { get; set; }
        public virtual ICollection<CpuserMainContractAccess> CpuserMainContractAccesses { get; set; }
    }
}
