using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class NotificationProcurement
    {
        public int Id { get; set; }
        public long? UserId { get; set; }
        public DateTime EntryDate { get; set; }
        public string Details { get; set; }
        public bool IsRead { get; set; }
    }
}
