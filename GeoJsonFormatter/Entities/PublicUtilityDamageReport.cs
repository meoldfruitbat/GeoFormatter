using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class PublicUtilityDamageReport
    {
        public PublicUtilityDamageReport()
        {
            PublicUtilityIndirectCauses = new HashSet<PublicUtilityIndirectCause>();
        }

        public int Id { get; set; }
        public long PublicUtilityDamageId { get; set; }
        public string DirectCause { get; set; }
        public bool DamageAvoidable { get; set; }
        public string ShortTermRecommendation { get; set; }
        public long? ShortTermPersonResponible { get; set; }
        public string ShortTermTimescale { get; set; }
        public string LongTermRecommendation { get; set; }
        public string LongTermTimescale { get; set; }
        public long? LongTermPersonResponible { get; set; }
        public string Liability { get; set; }
        public string ApproxCostOfRepair { get; set; }
        public string InsuranceCompanyContacted { get; set; }
        public decimal? QuotedCostOfRepair { get; set; }
        public decimal? AgreedCostOfRepair { get; set; }
        public DateTime? EnteredOn { get; set; }
        public decimal? LiablePercent { get; set; }

        public virtual PublicUtilityDamage PublicUtilityDamage { get; set; }
        public virtual ICollection<PublicUtilityIndirectCause> PublicUtilityIndirectCauses { get; set; }
    }
}
