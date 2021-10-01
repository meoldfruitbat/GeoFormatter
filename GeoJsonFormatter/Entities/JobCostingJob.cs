using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class JobCostingJob
    {
        public int Id { get; set; }
        public int? JobId { get; set; }
        public string JobNo { get; set; }
        public string Title { get; set; }
        public string JobStatus { get; set; }
        public string CustomerReference { get; set; }
        public string CustomerOrderNo { get; set; }
        public string LastUser { get; set; }
        public DateTime? DateTimeStamp { get; set; }
        public DateTime? LastUpdateTime { get; set; }
    }
}
