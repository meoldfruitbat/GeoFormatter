using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class CandidateSearch
    {
        public int Id { get; set; }
        public int SearchId { get; set; }
        public int? OperativeId { get; set; }
        public DateTime? SearchDateTime { get; set; }

        public virtual CandidateSearchDetail Search { get; set; }
    }
}
