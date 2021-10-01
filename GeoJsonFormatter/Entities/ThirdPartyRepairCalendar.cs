using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class ThirdPartyRepairCalendar
    {
        public Guid Id { get; set; }
        public Guid ThirdPartyRepairId { get; set; }
        public long Ticket { get; set; }
        public short Item { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public string DescriptionOfWork { get; set; }
    }
}
