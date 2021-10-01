using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class Stock
    {
        public Guid Id { get; set; }
        public string ItemDescription { get; set; }
        public int Qty { get; set; }
        public string Reference { get; set; }
        public int Threshold { get; set; }
        public string ApplicableTo { get; set; }
        public Guid? CategoryId { get; set; }
    }
}
