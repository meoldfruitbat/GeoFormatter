using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class CableRun
    {
        public int Id { get; set; }
        public long Qnumber { get; set; }
        public string ProjectName { get; set; }
        public string CableRunIdentifier { get; set; }
        public bool? Blocked { get; set; }
        public bool? Proved { get; set; }
        public decimal? ApproxDistance { get; set; }
    }
}
