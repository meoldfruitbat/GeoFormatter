using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class SupplierLookup
    {
        public long SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string SupplierAddress01 { get; set; }
        public string SupplierAddress02 { get; set; }
        public string SupplierAddress03 { get; set; }
        public string SupplierAddress04 { get; set; }
        public string SupplierDepot { get; set; }
        public string SupplierTel { get; set; }
        public string SupplierFax { get; set; }
        public string SupplierEmail { get; set; }
        public string SupplierWww { get; set; }
    }
}
