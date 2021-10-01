using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class OperativeType
    {
        public string IdCode { get; set; }
        public string OpType { get; set; }
        public string OpGroup { get; set; }
        public string OpDesc { get; set; }
        public int? MarkDeleted { get; set; }
    }
}
