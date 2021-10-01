using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class AccessControlTabElement
    {
        public int ContentId { get; set; }
        public string ElementId { get; set; }
        public int? TabNo { get; set; }
        public int? ElementNumber { get; set; }
        public string ElementTitle { get; set; }
        public int? ElementNumberQualifier1 { get; set; }
    }
}
