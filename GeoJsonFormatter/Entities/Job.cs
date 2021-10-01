using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class Job
    {
        public long Id { get; set; }
        public long? ContractFileId { get; set; }
        public long? QuoteId { get; set; }
        public long GangId { get; set; }
    }
}
