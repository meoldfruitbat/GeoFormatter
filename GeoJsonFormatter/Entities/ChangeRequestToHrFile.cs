using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class ChangeRequestToHrFile
    {
        public long Id { get; set; }
        public long OperativeId { get; set; }
        public long AppliedBy { get; set; }
        public long? EditedBy { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public DateTime LogedDate { get; set; }
        public DateTime? EditedDate { get; set; }

        public virtual OperativeFile AppliedByNavigation { get; set; }
        public virtual OperativeFile EditedByNavigation { get; set; }
        public virtual OperativeFile Operative { get; set; }
    }
}
