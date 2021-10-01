using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class TeamProjectPlantCost
    {
        public int Id { get; set; }
        public long QuoteId { get; set; }
        public long TeamId { get; set; }
        public decimal? WeeklyPlantCost { get; set; }
    }
}
