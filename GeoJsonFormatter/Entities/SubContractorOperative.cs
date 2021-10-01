using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class SubContractorOperative
    {
        public long SubContractorId { get; set; }
        public long OperativeId { get; set; }
        public long? AddedBy { get; set; }
        public DateTime? AddedOn { get; set; }

        public virtual OperativeFile Operative { get; set; }
        public virtual ClientContractorFile SubContractor { get; set; }
    }
}
