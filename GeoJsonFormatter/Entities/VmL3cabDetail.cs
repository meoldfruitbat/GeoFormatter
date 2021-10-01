using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class VmL3cabDetail
    {
        public long Id { get; set; }
        public int? Vmnbunumber { get; set; }
        public string CabinetDetails { get; set; }
        public string Location { get; set; }
        public string ExistingCab { get; set; }
        public string UcNc { get; set; }
        public int? L4total { get; set; }
        public string Number { get; set; }
        public string Name { get; set; }
        public int? OnOffsiteL4cabTotal { get; set; }
        public long? QuoteId { get; set; }
        public string CityFibreRef { get; set; }
    }
}
