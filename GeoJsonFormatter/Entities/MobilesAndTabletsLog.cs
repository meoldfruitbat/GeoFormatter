using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class MobilesAndTabletsLog
    {
        public int Id { get; set; }
        public int? MobilesAndTabletsId { get; set; }
        public string Action { get; set; }
        public string Comments { get; set; }
        public DateTime? DateOfAction { get; set; }
    }
}
