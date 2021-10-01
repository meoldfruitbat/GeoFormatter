using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class FaultPortalUserAuthProvidersDetail
    {
        public long Id { get; set; }
        public long FaultPortalLoginId { get; set; }
        public byte AuthentcationProvider { get; set; }
        public string AccessToken { get; set; }

        public virtual FaultPortalUserDetail FaultPortalLogin { get; set; }
    }
}
