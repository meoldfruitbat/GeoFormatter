using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class WorkCategory
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string IconPath { get; set; }
        public bool? IsNonT6 { get; set; }
    }
}
