using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class HolidayPlannerLog
    {
        public int Id { get; set; }
        public string ColumnName { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
        public DateTime ChangedOn { get; set; }
        public long? ChangedBy { get; set; }
        public string Comments { get; set; }
        public string TableName { get; set; }
        public long? PrimaryKeyId { get; set; }
    }
}
