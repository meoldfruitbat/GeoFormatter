using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class DigPermit
    {
        public long Id { get; set; }
        public Guid PermitId { get; set; }
        public Guid? AssignmentId { get; set; }
        public string FromAddress { get; set; }
        public string ToAddress { get; set; }
        public string GpsStart { get; set; }
        public string GpsEnd { get; set; }
        public decimal? Distance { get; set; }
        public bool? Granted { get; set; }
        public long? OperativeFocusId { get; set; }
        public string OperativeSignature { get; set; }
        public string SupervisorFocusId { get; set; }
        public string SupervisorSignature { get; set; }
        public string PermitType { get; set; }

        public virtual Assignment Assignment { get; set; }
    }
}
