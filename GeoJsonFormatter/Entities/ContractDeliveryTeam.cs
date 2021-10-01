using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class ContractDeliveryTeam
    {
        public long Id { get; set; }
        public int? BidTeamRoleId { get; set; }
        public long? OperativeId { get; set; }
        public long? QuoteId { get; set; }
        public long? LeadId { get; set; }
        public DateTime? AddedOn { get; set; }

        public virtual OperativeFile Operative { get; set; }
    }
}
