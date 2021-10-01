using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class GetCertificateList
    {
        public int CertificateId { get; set; }
        public string CertNumber { get; set; }
        public string CertificateName { get; set; }
        public int? NumberOfHeld { get; set; }
    }
}
