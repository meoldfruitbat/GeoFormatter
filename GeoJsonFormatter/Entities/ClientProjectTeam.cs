using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class ClientProjectTeam
    {
        public long Id { get; set; }
        public int? TeamRoleId { get; set; }
        public long? ClientId { get; set; }
        public long? QuoteId { get; set; }
        public long? LeadId { get; set; }
        public DateTime? AddedOn { get; set; }

        public virtual ClientsFile Client { get; set; }
    }
}
