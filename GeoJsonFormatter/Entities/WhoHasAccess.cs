using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class WhoHasAccess
    {
        public int AccessId { get; set; }
        public int? ContentId { get; set; }
        public int? GroupId { get; set; }
        public int? IndividualId { get; set; }
        public string Name { get; set; }
        public DateTime? LastModified { get; set; }
        public string LastModifiedBy { get; set; }
    }
}
