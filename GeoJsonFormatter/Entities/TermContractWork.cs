using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class TermContractWork
    {
        public long Id { get; set; }
        public string WorkHeader { get; set; }
        public string WorkDesc { get; set; }
        public string BaseUnit { get; set; }
        public string WorkRate { get; set; }
        public string ClientId { get; set; }
        public string ContractRootId { get; set; }
        public string Active { get; set; }
    }
}
