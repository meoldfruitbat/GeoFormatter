using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class TrainingCategory
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public int ParentId { get; set; }
    }
}
