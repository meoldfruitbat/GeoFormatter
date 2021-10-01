using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class FaultPortalUserDetail
    {
        public FaultPortalUserDetail()
        {
            FaultPortalUserAuthProvidersDetails = new HashSet<FaultPortalUserAuthProvidersDetail>();
        }

        public long Id { get; set; }
        public string LoginId { get; set; }
        public long? ClientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsEnableUser { get; set; }
        public DateTime AddedOn { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }

        public virtual ICollection<FaultPortalUserAuthProvidersDetail> FaultPortalUserAuthProvidersDetails { get; set; }
    }
}
