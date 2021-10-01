using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class Valuation
    {
        public Valuation()
        {
            ProjectWorks = new HashSet<ProjectWork>();
        }

        public long Id { get; set; }
        public long? Cvino { get; set; }
        public string RevisionName { get; set; }
        public decimal? ExpectedPercentage { get; set; }
        public string Information { get; set; }
        public string EstimatedTimeDelay { get; set; }
        public DateTime? SubmittedOn { get; set; }
        public bool? IsCostSubmitted { get; set; }
        public byte[] TimeStamp { get; set; }
        public DateTime? DateOfApplication { get; set; }
        public DateTime? ExpectedPaymentDate { get; set; }
        public DateTime? CostSubmittedDate { get; set; }
        public string CostSubmittedTo { get; set; }
        public Guid? Cviid { get; set; }

        public virtual Cvi CvinoNavigation { get; set; }
        public virtual ICollection<ProjectWork> ProjectWorks { get; set; }
    }
}
