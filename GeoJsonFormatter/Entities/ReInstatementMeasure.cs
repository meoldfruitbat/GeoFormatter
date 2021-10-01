using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class ReInstatementMeasure
    {
        public long Id { get; set; }
        public long? Qnumber { get; set; }
        public long? SupervisorId { get; set; }
        public long? GangerId { get; set; }
        public string ContractReference { get; set; }
        public DateTime? JobDate { get; set; }
        public DateTime? DateSubmitted { get; set; }
        public decimal? Length { get; set; }
        public decimal? Width { get; set; }
        public decimal? Depth { get; set; }
        public string ItemCode { get; set; }
        public string MaterialDescriptor { get; set; }
        public string MaterialSize { get; set; }
    }
}
