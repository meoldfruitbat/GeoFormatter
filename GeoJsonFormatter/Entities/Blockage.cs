using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class Blockage
    {
        public long Id { get; set; }
        public long EndPointId { get; set; }
        public long Qnumber { get; set; }
        public string Reason { get; set; }
        public string Comments { get; set; }
        public decimal? LengthFromCab { get; set; }
        public decimal? LengthFromToby { get; set; }
        public Guid? ImageId { get; set; }
        public bool? Cleared { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string ClearenceComments { get; set; }
        public long? RegisteredBy { get; set; }
        public long? ClearedBy { get; set; }
        public string LocationGps { get; set; }
        public string CableRunId { get; set; }
        public string PointAref { get; set; }
        public string PointAgps { get; set; }
        public string PointBref { get; set; }
        public string PointBgps { get; set; }
    }
}
