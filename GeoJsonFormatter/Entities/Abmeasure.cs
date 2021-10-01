using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class Abmeasure
    {
        public int Id { get; set; }
        public Guid AssignmentId { get; set; }
        public string WalkPoint { get; set; }
        public string TobyId { get; set; }
        public string Type { get; set; }
        public string ItemCode { get; set; }
        public string PropertiesServed { get; set; }
        public string Surface { get; set; }
        public string StartPrefix { get; set; }
        public string StartPoint { get; set; }
        public string EndPrefix { get; set; }
        public string EndPoint { get; set; }
        public decimal? Length { get; set; }
        public decimal? Width { get; set; }
        public string Comments { get; set; }
        public Guid MeasureId { get; set; }
        public string CompletedById { get; set; }
        public DateTime CompletedOn { get; set; }
        public long? Qnumber { get; set; }
        public string Location { get; set; }

        public virtual Assignment Assignment { get; set; }
    }
}
