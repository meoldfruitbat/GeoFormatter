using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class EventsManagement
    {
        public int Id { get; set; }
        public long? EventType { get; set; }
        public string Severity { get; set; }
        public DateTime Date { get; set; }
        public long RecordedById { get; set; }
        public string RecordedByName { get; set; }
        public string RecordedByEmail { get; set; }
        public string RecordedByContactNumber { get; set; }
        public string Location { get; set; }
        public Guid Identifier { get; set; }
        public long? Qnumber { get; set; }
        public bool InjuredPerson { get; set; }
        public string InitialDetails { get; set; }
        public string Category { get; set; }
    }
}
