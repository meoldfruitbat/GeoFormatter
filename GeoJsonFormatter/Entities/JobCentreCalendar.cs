using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class JobCentreCalendar
    {
        public Guid Id { get; set; }
        public long Ticket { get; set; }
        public short Item { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public long FitterId { get; set; }
        public string DescriptionOfWork { get; set; }
        public string Closed { get; set; }
    }
}
