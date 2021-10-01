using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class TimeSheet
    {
        public Guid Id { get; set; }
        public long OperativeId { get; set; }
        public DateTime? DateSubmitted { get; set; }
        public long? Ticket { get; set; }
        public short? Item { get; set; }
        public Guid? JobCentreCalendarId { get; set; }
        public string JobReference { get; set; }
    }
}
