using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class PlantMaintAttribute
    {
        public long MaintAttributesId { get; set; }
        public string GroupAttrName { get; set; }
        public string TestName { get; set; }
        public int? TestNumber { get; set; }
        public string TestType { get; set; }
    }
}
