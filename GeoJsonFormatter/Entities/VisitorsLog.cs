using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class VisitorsLog
    {
        public long Id { get; set; }
        public string GangLeader { get; set; }
        public string ContractReference { get; set; }
        public DateTime? DateLogged { get; set; }
        public string ScduserName { get; set; }
        public string Forename { get; set; }
        public string Surname { get; set; }
        public string Organisation { get; set; }
        public string VehicleReg { get; set; }
        public string Reason4visit { get; set; }
        public bool? SwitchIn { get; set; }
        public string SignatureIn { get; set; }
        public string Comments { get; set; }
        public bool? SwitchOut { get; set; }
        public string SignatureOut { get; set; }
        public DateTime? OnSiteTime { get; set; }
        public DateTime? OffSiteTime { get; set; }
        public DateTime? CreationDate { get; set; }
        public bool? Question1 { get; set; }
        public bool? Question2 { get; set; }
        public bool? Question3 { get; set; }
        public bool? Question4 { get; set; }
        public Guid? VisitorLogGuid { get; set; }
        public long? GangLeaderId { get; set; }
        public bool? Question5 { get; set; }
        public bool? Question6 { get; set; }
    }
}
