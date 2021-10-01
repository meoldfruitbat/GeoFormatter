using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class JobCardPartialUpdate
    {
        public Guid Id { get; set; }
        public long Ticket { get; set; }
        public short ItemNo { get; set; }
        public DateTime DateUpdated { get; set; }
        public string UpdatedBy { get; set; }
        public int UpdatedById { get; set; }
        public string Comments { get; set; }
        public DateTime? ReIssueDate { get; set; }
    }
}
