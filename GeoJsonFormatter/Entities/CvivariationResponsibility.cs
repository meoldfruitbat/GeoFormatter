using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class CvivariationResponsibility
    {
        public int Id { get; set; }
        public long? ContractId { get; set; }
        public string WorkId { get; set; }
        public long? OperativeId { get; set; }
        public string ContactType { get; set; }
    }
}
