using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class PlanningInfo
    {
        public long PlanningId { get; set; }
        public string ContractId { get; set; }
        public string QuoteId { get; set; }
        public string RoadName { get; set; }
        public string StreetUsrn { get; set; }
        public string Coordinates { get; set; }
        public string HighwaysAgency { get; set; }
        public string OtherParty { get; set; }
        public string TrafficSens { get; set; }
        public string EngDifficulties { get; set; }
        public string NoticeOrPermit { get; set; }
        public string Activity { get; set; }
        public string Works2Do { get; set; }
        public string TrafficManagement { get; set; }
        public string JobpackCompleted { get; set; }
        public DateTime? PrintsValidUntil { get; set; }
        public string PreSitedById { get; set; }
        public string PreSitedByName { get; set; }
        public decimal? ProgrammeDays { get; set; }
        public decimal? DurationDays { get; set; }
        public string NoticeNumber { get; set; }
        public DateTime? PlannedStart { get; set; }
        public DateTime? PlannedEnd { get; set; }
        public DateTime? ActualStart { get; set; }
        public DateTime? Backfilled { get; set; }
        public DateTime? Reinstated { get; set; }
        public DateTime? SiteClear { get; set; }
        public DateTime? RegisterRequired { get; set; }
        public DateTime? Registered { get; set; }
        public string Surface { get; set; }
        public int? HomesPassed { get; set; }
        public DateTime? AsBuiltComplete { get; set; }
        public DateTime? Vmmeasure { get; set; }
        public string CivilsComments { get; set; }
        public string LatitudeLongitude { get; set; }
        public string PreSiteComments { get; set; }
        public bool? PreSiteCheckComplete { get; set; }
    }
}
