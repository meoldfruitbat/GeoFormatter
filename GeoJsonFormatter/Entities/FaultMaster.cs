using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class FaultMaster
    {
        public FaultMaster()
        {
            FaultActivities = new HashSet<FaultActivity>();
        }

        public long FaultId { get; set; }
        public string FaultSequenceNo { get; set; }
        public DateTime IncidentDate { get; set; }
        public string Description { get; set; }
        public long? ClientId { get; set; }
        public int Status { get; set; }
        public DateTime? AddedOn { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public byte[] Timestamp { get; set; }
        public string Area { get; set; }
        public long? FaultQuoteId { get; set; }
        public string LocationName { get; set; }

        public virtual ICollection<FaultActivity> FaultActivities { get; set; }
    }
}
