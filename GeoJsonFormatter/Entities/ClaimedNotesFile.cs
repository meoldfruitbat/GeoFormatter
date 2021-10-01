using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class ClaimedNotesFile
    {
        public long NotesId { get; set; }
        public string ContractReference { get; set; }
        public string QuoteId { get; set; }
        public string ContractId { get; set; }
        public string ConPrefix { get; set; }
        public string NotesGang { get; set; }
        public string NotesText { get; set; }
        public DateTime? NotesDate { get; set; }
        public DateTime? PostedByGanger { get; set; }
        public DateTime? ApprovedBySupervisor { get; set; }
        public string SupervisorText { get; set; }
        public string PostedByGangerName { get; set; }
        public string ApprovedBySupervisorName { get; set; }
        public DateTime? PostedByAdmin { get; set; }
        public string DailyChecksTodaysTask { get; set; }
        public string DailyChecksComments { get; set; }
        public string AnyDelays { get; set; }
        public string AnyAddnlWorkReq { get; set; }
        public string AdminText { get; set; }
        public int? VmhomesPassed { get; set; }
        public Guid? ImageId { get; set; }
        public string SupervisorDelays { get; set; }
        public string SupervisorAddnlWork { get; set; }
        public string PayrollComment { get; set; }
        public string StartAddress { get; set; }
        public string EndAddress { get; set; }
    }
}
