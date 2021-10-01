using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class SystemTimeLog
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public DateTime? LoginDate { get; set; }
        public bool? IsLogin { get; set; }
    }
}
