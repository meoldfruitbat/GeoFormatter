using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class ScdCableStockUse
    {
        public long Id { get; set; }
        public string ScdCableDrumNo { get; set; }
        public string ContractId { get; set; }
        public string ContractName { get; set; }
        public int? HowMuchUsed { get; set; }
        public string UsedById { get; set; }
        public string UsedByName { get; set; }
        public DateTime? UsedDate { get; set; }
        public string CableType { get; set; }
        public string CoreCount { get; set; }
        public decimal? StartReading { get; set; }
        public decimal? EndReading { get; set; }
        public Guid? ClaimId { get; set; }
        public string CableRunIdentifier { get; set; }
        public decimal? ExpectedStartReading { get; set; }
    }
}
