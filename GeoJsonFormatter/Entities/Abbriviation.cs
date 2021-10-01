using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class Abbriviation
    {
        public int Id { get; set; }
        public string Abb { get; set; }
        public string FullName { get; set; }
    }
}
