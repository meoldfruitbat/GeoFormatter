using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class XmlLogging
    {
        public int Id { get; set; }
        public string Uid { get; set; }
        public DateTime ReceivedTimestamp { get; set; }
        public DateTime Timestamp { get; set; }
        public string Namespace { get; set; }
        public string Data { get; set; }
    }
}
