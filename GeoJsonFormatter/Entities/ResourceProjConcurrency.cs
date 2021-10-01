using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class ResourceProjConcurrency
    {
        public long Id { get; set; }
        public long? ProjectId { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public byte[] TimeStampValue { get; set; }
    }
}
