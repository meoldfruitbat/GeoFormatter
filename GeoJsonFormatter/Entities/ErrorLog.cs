using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class ErrorLog
    {
        public long Id { get; set; }
        public string Type { get; set; }
        public string FunctionName { get; set; }
        public string InputData { get; set; }
        public string OutputData { get; set; }
        public int? UserId { get; set; }
        public string GroupType { get; set; }
        public string FullErrorDescription { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}
