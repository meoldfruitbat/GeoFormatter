using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class ContractorDetailReference
    {
        public int Id { get; set; }
        public long ContractorDetailId { get; set; }
        public int? TradeId { get; set; }
        public long? ClientId { get; set; }
        public long? RegionId { get; set; }
        public int? ContractorDetailReferenceType { get; set; }
        public byte[] TimeStamp { get; set; }

        public virtual ClientContractorFile Client { get; set; }
        public virtual ContractorDetail ContractorDetail { get; set; }
        public virtual ReferenceDatum ContractorDetailReferenceTypeNavigation { get; set; }
        public virtual Trade Trade { get; set; }
    }
}
