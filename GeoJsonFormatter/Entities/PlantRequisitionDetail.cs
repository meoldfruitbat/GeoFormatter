using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class PlantRequisitionDetail
    {
        public int Id { get; set; }
        public int? PlantRequestId { get; set; }
        public long? PlantId { get; set; }
        public int? Quantity { get; set; }
        public DateTime? RequiredByDate { get; set; }

        public virtual PlantLookup Plant { get; set; }
        public virtual PlantRequestDetail PlantRequest { get; set; }
    }
}
