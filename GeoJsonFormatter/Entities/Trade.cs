using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class Trade
    {
        public Trade()
        {
            ContractorDetailReferences = new HashSet<ContractorDetailReference>();
            TeamTrades = new HashSet<TeamTrade>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ContractorDetailReference> ContractorDetailReferences { get; set; }
        public virtual ICollection<TeamTrade> TeamTrades { get; set; }
    }
}
