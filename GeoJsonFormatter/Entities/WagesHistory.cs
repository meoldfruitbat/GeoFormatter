using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class WagesHistory
    {
        public int Id { get; set; }
        public decimal? OldValue { get; set; }
        public decimal? NewValue { get; set; }
        public string FieldName { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
    }
}
