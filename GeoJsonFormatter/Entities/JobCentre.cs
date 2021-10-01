using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class JobCentre
    {
        public Guid Id { get; set; }
        public long Ticket { get; set; }
        public long RelatedId { get; set; }
        public short Item { get; set; }
        public string JobType { get; set; }
        public short Status { get; set; }
        public long? JobAllocatedTo { get; set; }
        public DateTime? JobAllocatedDate { get; set; }
        public long? JobAllocatedBy { get; set; }
        public Guid? JobCardNo { get; set; }
        public string JobRequirements { get; set; }
        public DateTime DateTimeCreated { get; set; }
    }
}
