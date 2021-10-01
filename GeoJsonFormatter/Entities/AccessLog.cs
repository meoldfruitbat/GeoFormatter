using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class AccessLog
    {
        public int Id { get; set; }
        public int AccessId { get; set; }
        public int ContentId { get; set; }
        public int GroupId { get; set; }
        public int IndividualId { get; set; }
        public string Name { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }
        public bool? Type { get; set; }
        public string ElementTitle { get; set; }
        public int TabNo { get; set; }
        public int ElementType { get; set; }
    }
}
