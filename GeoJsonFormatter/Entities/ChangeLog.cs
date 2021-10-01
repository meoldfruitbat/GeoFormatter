using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class ChangeLog
    {
        public long Id { get; set; }
        public string ColumnName { get; set; }
        public string NewValue { get; set; }
        public string OldValue { get; set; }
        public DateTime? WhenChanged { get; set; }
        public string WhoChanged { get; set; }
        public long? ChangedBy { get; set; }
        public string TableName { get; set; }
        public string SectionName { get; set; }
        public DateTime? AddedDate { get; set; }
        public long? ChangedInUserId { get; set; }
    }
}
