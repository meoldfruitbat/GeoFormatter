using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class ResourceWorkDate
    {
        public long Id { get; set; }
        public long ResourceDataId { get; set; }
        public long GangOperativesId { get; set; }
        public DateTime WorkDate { get; set; }
        public long SupervisorsId { get; set; }
        public bool EveningWork { get; set; }
    }
}
