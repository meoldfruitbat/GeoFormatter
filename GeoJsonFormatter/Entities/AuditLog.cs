using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class AuditLog
    {
        public int Id { get; set; }
        public int? FileId { get; set; }
        public string Path { get; set; }
        public string FieldName { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
        public byte[] Modified { get; set; }
        public string ModifiedBy { get; set; }
    }
}
