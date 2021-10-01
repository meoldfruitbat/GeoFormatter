using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class ContractTimescaleDetail
    {
        public long Id { get; set; }
        public string ProjectId { get; set; }
        public string DferesponseTime { get; set; }
        public string PmiresponseTime { get; set; }
        public decimal? ClientWarning { get; set; }
        public string EventSubmissionTime { get; set; }
        public decimal? Cewarning { get; set; }
        public decimal? InternalWarning { get; set; }
        public string DferesponseUnit { get; set; }
        public string PmiresponseUnit { get; set; }
        public string CeresponseUnit { get; set; }
        public int? Addedby { get; set; }
        public DateTime? Addedon { get; set; }
        public int? Updatedby { get; set; }
        public DateTime? Updatedon { get; set; }
    }
}
