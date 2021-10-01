using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class RejectPlantDatum
    {
        public long Id { get; set; }
        public long PlantId { get; set; }
        public DateTime? TransferCancelledDate { get; set; }
        public string TransferCommentsIn { get; set; }
        public string TransferFromId { get; set; }
        public string TransferToId { get; set; }
        public string Status { get; set; }
        public string TransferFromName { get; set; }
    }
}
