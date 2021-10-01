using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class ContractsDayBookComment
    {
        public long Id { get; set; }
        public string ContractReference { get; set; }
        public DateTime DateSubmitted { get; set; }
        public string Comments { get; set; }
        public string CommentsAddedBy { get; set; }
    }
}
