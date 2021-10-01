using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class PlantMaintenanceComment
    {
        public Guid Id { get; set; }
        public Guid CommentId { get; set; }
        public DateTime DateSubmitted { get; set; }
        public string Comment { get; set; }
        public string CommentMadeBy { get; set; }
    }
}
