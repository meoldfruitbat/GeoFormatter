using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class ItemStock
    {
        public int Id { get; set; }
        public int? ItemId { get; set; }
        public long? LocationId { get; set; }
        public long? PersonId { get; set; }
        public decimal Quantity { get; set; }
        public int? ItemSupplierId { get; set; }

        public virtual Item Item { get; set; }
        public virtual ItemSupplier ItemSupplier { get; set; }
        public virtual ClientCompanyFile Location { get; set; }
        public virtual OperativeFile Person { get; set; }
    }
}
