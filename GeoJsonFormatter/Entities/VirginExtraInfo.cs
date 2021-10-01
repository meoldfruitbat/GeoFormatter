using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class VirginExtraInfo
    {
        public int ExtraInfoId { get; set; }
        public string ContractRef { get; set; }
        public string QuoteId { get; set; }
        public string AdditionalComments { get; set; }
        public string AccountProjectCode { get; set; }
        public string Ponumber { get; set; }
        public string LocalAuthority { get; set; }
        public string OriginatorPlanner { get; set; }
        public string LocationOffice { get; set; }
        public string PlannerContact { get; set; }
        public DateTime? DateTime { get; set; }
        public string DtifranchiseName { get; set; }
        public string IcomssiteId { get; set; }
        public string IcomsfranchiseNumber { get; set; }
    }
}
