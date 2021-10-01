using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class PlantComponentCategory
    {
        public Guid Id { get; set; }
        public string Category { get; set; }
        public string SubCat1 { get; set; }
        public string SubCat2 { get; set; }
        public string SubCat3 { get; set; }
        public string SubCat4 { get; set; }
        public string SubCat5 { get; set; }
    }
}
