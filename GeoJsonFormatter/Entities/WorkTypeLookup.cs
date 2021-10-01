using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class WorkTypeLookup
    {
        public WorkTypeLookup()
        {
            AuditExpectedPhotos = new HashSet<AuditExpectedPhoto>();
            CompanySetupExpectedPhotos = new HashSet<CompanySetupExpectedPhoto>();
            ProjectExpectedPhotos = new HashSet<ProjectExpectedPhoto>();
            QualityAuditDetails = new HashSet<QualityAuditDetail>();
        }

        public int Id { get; set; }
        public string WorkType { get; set; }
        public bool IsDefault { get; set; }
        public string Value { get; set; }

        public virtual ICollection<AuditExpectedPhoto> AuditExpectedPhotos { get; set; }
        public virtual ICollection<CompanySetupExpectedPhoto> CompanySetupExpectedPhotos { get; set; }
        public virtual ICollection<ProjectExpectedPhoto> ProjectExpectedPhotos { get; set; }
        public virtual ICollection<QualityAuditDetail> QualityAuditDetails { get; set; }
    }
}
