using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class CommercialDetail
    {
        public long Id { get; set; }
        public string CommercialSummary { get; set; }
        public long? QuoteId { get; set; }
        public TimeSpan? MonToFriStartTime { get; set; }
        public TimeSpan? MonToFriEndTime { get; set; }
        public TimeSpan? SaturdayStartTime { get; set; }
        public TimeSpan? SaturdayEndTime { get; set; }
        public TimeSpan? SundayStartTime { get; set; }
        public TimeSpan? SundayEndTime { get; set; }
        public bool? MonToFriNa { get; set; }
        public bool? SaturdayNa { get; set; }
        public bool? SundayNa { get; set; }
    }
}
