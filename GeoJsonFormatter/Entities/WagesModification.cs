using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class WagesModification
    {
        public long WagesModificationId { get; set; }
        public int? LabourId { get; set; }
        public string ModificationText { get; set; }
        public DateTime? ModificationDate { get; set; }
        public string ModifiedBy { get; set; }
        public string AnyAdminComments { get; set; }
    }
}
