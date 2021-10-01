using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class JobCardChecksResponse
    {
        public Guid Id { get; set; }
        public long Ticket { get; set; }
        public short ItemNo { get; set; }
        public string RelatedChecksId { get; set; }
        public string Response { get; set; }
        public long? ListIndex { get; set; }
    }
}
