using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class CpuserAuthProvidersDetail
    {
        public long Id { get; set; }
        public long CploginId { get; set; }
        public byte AuthentcationProvider { get; set; }
        public string AccessToken { get; set; }

        public virtual CpuserDetail Cplogin { get; set; }
    }
}
