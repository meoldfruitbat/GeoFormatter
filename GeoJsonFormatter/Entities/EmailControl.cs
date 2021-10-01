using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class EmailControl
    {
        public long Id { get; set; }
        public DateTime? MessageDateTime { get; set; }
        public string QuoteNumber { get; set; }
        public string Direction { get; set; }
        public string PrivateSelection { get; set; }
        public string MessageSubject { get; set; }
        public string MessageFrom { get; set; }
        public string MessageTo { get; set; }
        public string FileName { get; set; }
    }
}
