using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class AliasType
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public int Priotity { get; set; }
        public string FirstNameElement { get; set; }
        public string Seperator { get; set; }
        public string SecondNameElement { get; set; }
        public DateTime? AddedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }

        public virtual CompanySetup Company { get; set; }
    }
}
