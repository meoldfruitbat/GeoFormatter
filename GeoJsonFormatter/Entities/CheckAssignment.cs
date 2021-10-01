using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class CheckAssignment
    {
        public int Id { get; set; }
        public string Action { get; set; }
        public long UserFocusId { get; set; }
        public string Status { get; set; }
        public long Vmnbunumber { get; set; }
        public string ProjectName { get; set; }
    }
}
