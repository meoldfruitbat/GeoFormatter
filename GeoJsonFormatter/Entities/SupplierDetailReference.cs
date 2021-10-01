using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class SupplierDetailReference
    {
        public int Id { get; set; }
        public int SupplierDetailId { get; set; }
        public int SupplierDetailReferenceType { get; set; }
        public int? ProductTypeId { get; set; }
        public int? WorkStreamId { get; set; }
        public long? ClientId { get; set; }

        public virtual ClientCompanyFile Client { get; set; }
        public virtual ItemType ProductType { get; set; }
        public virtual SupplierDetail SupplierDetail { get; set; }
        public virtual ReferenceDatum SupplierDetailReferenceTypeNavigation { get; set; }
        public virtual Workstream WorkStream { get; set; }
    }
}
