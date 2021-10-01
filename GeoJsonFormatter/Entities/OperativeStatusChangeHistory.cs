using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class OperativeStatusChangeHistory
    {
        public long Id { get; set; }
        public long? OperativeId { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? Active { get; set; }

        public virtual OperativeFile Operative { get; set; }
    }
}
