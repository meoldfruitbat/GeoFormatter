using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class VmL5cabDetail
    {
        public long Id { get; set; }
        public string AssociatedL4number { get; set; }
        public string L5number { get; set; }
        public string Location { get; set; }
        public int? HomesServed { get; set; }
        public int? Vmnbunumber { get; set; }
        public long? QuoteId { get; set; }
    }
}
