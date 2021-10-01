using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class TrainingRequest
    {
        public long Id { get; set; }
        public long? OperativeId { get; set; }
        public string Request { get; set; }
        public bool? IsTraininProviderFound { get; set; }
        public string InputDetails { get; set; }
        public DateTime? AddedOn { get; set; }

        public virtual OperativeFile Operative { get; set; }
    }
}
