using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class PlantIssueComment
    {
        public long Id { get; set; }
        public long? PlantIssueId { get; set; }
        public DateTime? DateSubmitted { get; set; }
        public string Comment { get; set; }
        public string CommentMadeBy { get; set; }
    }
}
