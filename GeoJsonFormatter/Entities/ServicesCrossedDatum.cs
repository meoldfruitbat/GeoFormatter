using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class ServicesCrossedDatum
    {
        public int Id { get; set; }
        public string ContractReference { get; set; }
        public string QuoteId { get; set; }
        public string ContractId { get; set; }
        public string GangLeaderId { get; set; }
        public string GangLeaderName { get; set; }
        public string ServicesCrossedData { get; set; }
        public DateTime? PostedDate { get; set; }
    }
}
