using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class CvistatusUpdateLog
    {
        public int Id { get; set; }
        public long? Cvino { get; set; }
        public int? OldStatusValue { get; set; }
        public int? NewStatusValue { get; set; }
        public long? LastModifiedBy { get; set; }
        public DateTime? LastModifiedOn { get; set; }

        public virtual Cvi CvinoNavigation { get; set; }
    }
}
