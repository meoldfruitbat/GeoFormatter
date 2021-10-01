using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class ExtranetClientAccessList
    {
        public long Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ForeName { get; set; }
        public string LastName { get; set; }
        public string ClientId { get; set; }
        public string CompanyName { get; set; }
        public string CompanyId { get; set; }
        public long? CrossRefId { get; set; }
        public string Active { get; set; }
        public string SydrfilterGoups { get; set; }
    }
}
