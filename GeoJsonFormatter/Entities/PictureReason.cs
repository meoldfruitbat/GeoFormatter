using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class PictureReason
    {
        public PictureReason()
        {
            AuditExpectedPhotos = new HashSet<AuditExpectedPhoto>();
            CompanySetupExpectedPhotos = new HashSet<CompanySetupExpectedPhoto>();
            ProjectExpectedPhotos = new HashSet<ProjectExpectedPhoto>();
        }

        public int Id { get; set; }
        public string Reason { get; set; }
        public string Description { get; set; }

        public virtual ICollection<AuditExpectedPhoto> AuditExpectedPhotos { get; set; }
        public virtual ICollection<CompanySetupExpectedPhoto> CompanySetupExpectedPhotos { get; set; }
        public virtual ICollection<ProjectExpectedPhoto> ProjectExpectedPhotos { get; set; }
    }
}
