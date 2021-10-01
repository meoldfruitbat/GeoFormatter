using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class Part
    {
        public Guid Id { get; set; }
        public long Ticket { get; set; }
        public short ItemNo { get; set; }
        public long SupplierPricesId { get; set; }
        public string SupplierPricesSid { get; set; }
        public int Qty { get; set; }
        public DateTime DateSelected { get; set; }
    }
}
