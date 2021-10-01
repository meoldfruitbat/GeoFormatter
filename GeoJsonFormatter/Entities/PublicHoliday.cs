using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class PublicHoliday
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string CalendarYear { get; set; }
        public int Type { get; set; }
        public bool? IsRemoveFromAllowance { get; set; }
    }
}
