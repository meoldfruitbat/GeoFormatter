using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class Appointment
    {
        public long Id { get; set; }
        public long? EntityId { get; set; }
        public long? CompanyId { get; set; }
        public string ExAppId { get; set; }
        public string Subject { get; set; }
        public string Location { get; set; }
        public long? RegardingId { get; set; }
        public string Required { get; set; }
        public string Optional { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Duration { get; set; }
        public bool AllDayEvent { get; set; }
        public string ShowTimeAs { get; set; }
        public string Priority { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public DateTime DateEntered { get; set; }
        public DateTime DateLastModified { get; set; }
        public long ContactId { get; set; }
        public long OwnerId { get; set; }
        public long OrganiserId { get; set; }
        public string EntityType { get; set; }
    }
}
