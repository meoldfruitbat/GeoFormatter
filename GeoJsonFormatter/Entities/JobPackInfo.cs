using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class JobPackInfo
    {
        public long Id { get; set; }
        public string ContractNumber { get; set; }
        public string FileName { get; set; }
        public string Active { get; set; }
        public string IsItAfolder { get; set; }
        public string FolderPath { get; set; }
        public DateTime? UploadDateTime { get; set; }
        public string OperativeInformed { get; set; }
        public string Qnumber { get; set; }
        public string DocumentTitle { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string SharePointFileId { get; set; }
    }
}
