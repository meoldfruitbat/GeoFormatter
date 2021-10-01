using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class OperationDetail
    {
        public int Id { get; set; }
        public long? MainContractId { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string Postcode { get; set; }
        public string ContactName { get; set; }
        public string ContactNumber { get; set; }
        public TimeSpan? MonToFriStartTime { get; set; }
        public TimeSpan? MonToFriEndTime { get; set; }
        public TimeSpan? SaturdayStartTime { get; set; }
        public TimeSpan? SaturdayEndTime { get; set; }
        public TimeSpan? SundayStartTime { get; set; }
        public TimeSpan? SundayEndTime { get; set; }
        public string OperationalSummary { get; set; }
        public bool? YardInfoNa { get; set; }
        public bool? MonToFriNa { get; set; }
        public bool? SaturdayNa { get; set; }
        public bool? SundayNa { get; set; }
        public DateTime? ClientDefectLiabilityPeriod { get; set; }
        public DateTime? LadefectLiabilityPeriod { get; set; }

        public virtual ContractFile MainContract { get; set; }
    }
}
