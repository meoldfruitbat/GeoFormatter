using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class MethodStatement
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string Statement { get; set; }
        public string Reference { get; set; }
    }
}
