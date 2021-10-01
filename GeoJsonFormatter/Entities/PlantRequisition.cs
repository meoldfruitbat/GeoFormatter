using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class PlantRequisition
    {
        public long Id { get; set; }
        public string ProjectName { get; set; }
        public string ProjectAddress { get; set; }
        public string SupervisorLogOn { get; set; }
        public string Cnumber { get; set; }
        public DateTime RequisitionDate { get; set; }
        public string ProjectDuration { get; set; }
        public string PlantType { get; set; }
        public short Quantity { get; set; }
        public DateTime DateRequired { get; set; }
        public string DurationOfUse { get; set; }
        public string Specifications { get; set; }
        public string OpRequiringPlant { get; set; }
    }
}
