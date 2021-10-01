using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class ThirdPartyRepairCompany
    {
        public Guid Id { get; set; }
        public string CompanyName { get; set; }
        public string Location { get; set; }
        public string ContactNumber { get; set; }
        public string EmailAddress { get; set; }
    }
}
