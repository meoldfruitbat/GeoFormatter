using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class MaterialRequisition
    {
        public long Id { get; set; }
        public string ProjectName { get; set; }
        public string ProjectAddress { get; set; }
        public string SupervisorLogOn { get; set; }
        public string Cnumber { get; set; }
        public DateTime RequisitionDate { get; set; }
        public string MaterialType { get; set; }
        public short Quantity { get; set; }
        public DateTime DateRequired { get; set; }
        public string OtherDetails { get; set; }
        public string OpRequiringMaterial { get; set; }
    }
}
