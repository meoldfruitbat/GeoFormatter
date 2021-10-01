using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class PlanningLocationComment
    {
        public long Id { get; set; }
        public long? PlanningRoadId { get; set; }
        public string Usrncomments { get; set; }
        public string CoOrdscomments { get; set; }
        public string Highwayscomments { get; set; }
        public string OtherPartycomments { get; set; }
        public string TrafficMgmntcomments { get; set; }
        public string NoticePermitcomments { get; set; }
        public string CivilsCablingcomments { get; set; }
        public string TrafficSenscomments { get; set; }
        public string EngDiffcomments { get; set; }
        public string Rejectioncomments { get; set; }
        public string JobPackGoodOrRejected { get; set; }
        public DateTime? DateTimePosted { get; set; }
        public string PostedBy { get; set; }
    }
}
