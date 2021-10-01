using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class Ppeworkwear
    {
        public long Id { get; set; }
        public long? OperativeId { get; set; }
        public string TopSize { get; set; }
        public string TrouserSize { get; set; }
        public int? ShoeSize { get; set; }
        public DateTime? AddedOn { get; set; }
    }
}
