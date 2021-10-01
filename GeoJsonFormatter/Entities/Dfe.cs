using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class Dfe
    {
        public int Id { get; set; }
        public string StreetName { get; set; }
        public Guid AssignmentId { get; set; }
        public Guid DfeId { get; set; }
        public long Qnumber { get; set; }
        public string Comments { get; set; }
        public string ToAddress { get; set; }
        public string FromAddress { get; set; }
        public DateTime LastUpdateTime { get; set; }
        public string Status { get; set; }

        public virtual Assignment Assignment { get; set; }
    }
}
