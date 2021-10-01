using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class OperativeDocLog
    {
        public int Id { get; set; }
        public long OperativeId { get; set; }
        public string DocType { get; set; }
        public string DocName { get; set; }
        public string NewFileName { get; set; }
        public string DocSize { get; set; }
        public DateTime UploadStart { get; set; }
        public DateTime? UploadEnd { get; set; }
        public long UploadedBy { get; set; }
        public bool IsUploadCompleted { get; set; }
    }
}
