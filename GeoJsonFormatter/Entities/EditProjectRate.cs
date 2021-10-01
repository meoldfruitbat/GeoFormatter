﻿using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class EditProjectRate
    {
        public int Id { get; set; }
        public string Header { get; set; }
        public string Description { get; set; }
        public string Unit { get; set; }
        public decimal? Rate { get; set; }
        public long WorkId { get; set; }
        public long QuoteId { get; set; }
        public long SubcontractorId { get; set; }
        public string Type { get; set; }
    }
}