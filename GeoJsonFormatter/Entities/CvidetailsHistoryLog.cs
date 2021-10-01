using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class CvidetailsHistoryLog
    {
        public int Id { get; set; }
        public long? Cvino { get; set; }
        public string FieldName { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
        public long? LastModifiedBy { get; set; }
        public DateTime? LastModifiedOn { get; set; }

        public virtual Cvi CvinoNavigation { get; set; }
    }
}
