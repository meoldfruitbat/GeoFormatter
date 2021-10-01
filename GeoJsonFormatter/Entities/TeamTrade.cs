using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class TeamTrade
    {
        public int TeamId { get; set; }
        public int TradeId { get; set; }
        public bool? IsActive { get; set; }

        public virtual TeamDetail Team { get; set; }
        public virtual Trade Trade { get; set; }
    }
}
