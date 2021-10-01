using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class FittersWorkingOnRepair
    {
        public Guid Id { get; set; }
        public long FitterId { get; set; }
        public long FitterScdId { get; set; }
        public Guid JobCardId { get; set; }
        public DateTime? StartDateTime { get; set; }
        public DateTime? EndDateTime { get; set; }
        public long? Ticket { get; set; }
    }
}
