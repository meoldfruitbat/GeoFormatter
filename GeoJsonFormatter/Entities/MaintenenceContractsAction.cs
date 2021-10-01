using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class MaintenenceContractsAction
    {
        public int Id { get; set; }
        public string MaintContractId { get; set; }
        public string ReportedBy { get; set; }
        public DateTime? ReportedOn { get; set; }
        public int TicketNo { get; set; }
        public string FaultDetails { get; set; }
        public string Info { get; set; }
        public string Status { get; set; }
        public string AssignedProjectManager { get; set; }
        public DateTime? AssignedProjectManagerDateTime { get; set; }
    }
}
