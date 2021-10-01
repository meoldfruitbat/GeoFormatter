using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class OperativeTaskStatus
    {
        public OperativeTaskStatus()
        {
            OperativeTasks = new HashSet<OperativeTask>();
        }

        public int Id { get; set; }
        public string Status { get; set; }
        public string StatusColour { get; set; }

        public virtual ICollection<OperativeTask> OperativeTasks { get; set; }
    }
}
