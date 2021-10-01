using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class JobCard
    {
        public Guid Id { get; set; }
        public long Ticket { get; set; }
        public short ItemNo { get; set; }
        public long FitterId { get; set; }
        public DateTime Created { get; set; }
        public string Priority { get; set; }
        public string Location { get; set; }
        public string OriginOfWork { get; set; }
        public string ReasonForWork { get; set; }
        public DateTime? LastPartialSubmittedDate { get; set; }
        public DateTime? DateSubmitted { get; set; }
        public string CreatedBy { get; set; }
        public string RepairSummary { get; set; }
        public DateTime JobStart { get; set; }
        public DateTime? JobEnd { get; set; }
        public int HoursOnMachine { get; set; }
        public int Mileage { get; set; }
        public string AdditionalDocumentation { get; set; }
        public DateTime? TravelTime { get; set; }
    }
}
