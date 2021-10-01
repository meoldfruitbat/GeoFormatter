using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class SdhMusReconciliationSummary
    {
        public SdhMusReconciliationSummary()
        {
            SdhMusReconciliationDefects = new HashSet<SdhMusReconciliationDefect>();
            SdhMusReconciliationJobMovements = new HashSet<SdhMusReconciliationJobMovement>();
            SdhMusReconciliationMaterials = new HashSet<SdhMusReconciliationMaterial>();
            SdhMusReconciliationNonStds = new HashSet<SdhMusReconciliationNonStd>();
            SdhMusReconciliationS74andFpns = new HashSet<SdhMusReconciliationS74andFpn>();
            SdhMusReconciliationWorksData = new HashSet<SdhMusReconciliationWorksDatum>();
        }

        public int Id { get; set; }
        public int? ApplicationNo { get; set; }
        public string OrderNo { get; set; }
        public DateTime? ValidUpTo { get; set; }
        public string AccountCode { get; set; }
        public string SubContractorName { get; set; }
        public string ContractName { get; set; }
        public string IssuedBy { get; set; }
        public DateTime? IssueDate { get; set; }
        public int? InputBy { get; set; }
        public DateTime? InputOn { get; set; }

        public virtual ICollection<SdhMusReconciliationDefect> SdhMusReconciliationDefects { get; set; }
        public virtual ICollection<SdhMusReconciliationJobMovement> SdhMusReconciliationJobMovements { get; set; }
        public virtual ICollection<SdhMusReconciliationMaterial> SdhMusReconciliationMaterials { get; set; }
        public virtual ICollection<SdhMusReconciliationNonStd> SdhMusReconciliationNonStds { get; set; }
        public virtual ICollection<SdhMusReconciliationS74andFpn> SdhMusReconciliationS74andFpns { get; set; }
        public virtual ICollection<SdhMusReconciliationWorksDatum> SdhMusReconciliationWorksData { get; set; }
    }
}
