using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class RecruitmentSearchHistory
    {
        public int Id { get; set; }
        public string Keyword { get; set; }
        public DateTime SearchDate { get; set; }
        public long SearchBy { get; set; }
        public string SearchReference { get; set; }
    }
}
