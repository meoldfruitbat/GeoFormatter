using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class CompanyDomain
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public string Domain { get; set; }
        public DateTime? AddedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }

        public virtual CompanySetup Company { get; set; }
    }
}
