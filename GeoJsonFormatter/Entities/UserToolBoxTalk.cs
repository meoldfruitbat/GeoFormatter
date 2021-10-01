using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class UserToolBoxTalk
    {
        public int Id { get; set; }
        public string ToolBoxTalkCode { get; set; }
        public DateTime? DistributionDate { get; set; }
        public long SupervisorId { get; set; }
        public long GangLeaderId { get; set; }
        public long FocusId { get; set; }
        public string SignatureFileName { get; set; }
        public DateTime? Date { get; set; }
        public bool? SaveToTraining { get; set; }
        public decimal? TimeTaken { get; set; }
    }
}
