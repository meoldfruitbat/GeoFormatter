using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class CertificateLookup
    {
        public int Id { get; set; }
        public string CertificateName { get; set; }
        public int? Weighting { get; set; }
        public string CandidateProfile { get; set; }
        public string CertNumber { get; set; }
        public bool? IsExclueExpired { get; set; }
        public bool IsIncludeSubContractorOperatives { get; set; }
        public bool IsIncludeInActiveUser { get; set; }
    }
}
