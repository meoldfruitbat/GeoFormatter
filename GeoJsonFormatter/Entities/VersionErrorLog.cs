using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class VersionErrorLog
    {
        public int Id { get; set; }
        public string Filename { get; set; }
        public string ErrorDescription { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
