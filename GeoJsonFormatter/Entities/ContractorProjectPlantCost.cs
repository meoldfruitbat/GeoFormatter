using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class ContractorProjectPlantCost
    {
        public int Id { get; set; }
        public long QuoteId { get; set; }
        public long SubcontractorId { get; set; }
        public decimal? WeeklyPlantCost { get; set; }
    }
}
