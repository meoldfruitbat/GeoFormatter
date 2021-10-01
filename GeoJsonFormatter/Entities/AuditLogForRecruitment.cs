using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class AuditLogForRecruitment
    {
        public int Id { get; set; }
        public int Identifier { get; set; }
        public short Type { get; set; }
        public string ColumnName { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
        public DateTime ModifiedOn { get; set; }
        public long? ModifiedBy { get; set; }
        public string ModifiedByName { get; set; }
    }
}
