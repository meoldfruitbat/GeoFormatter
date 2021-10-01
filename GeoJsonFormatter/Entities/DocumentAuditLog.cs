using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class DocumentAuditLog
    {
        public int Id { get; set; }
        public int DocumentId { get; set; }
        public string Action { get; set; }
        public string FieldName { get; set; }
        public long ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public decimal? Version { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }

        public virtual OperativeFile ModifiedByNavigation { get; set; }
    }
}
