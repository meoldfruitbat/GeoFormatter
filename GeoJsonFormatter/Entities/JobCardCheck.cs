using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class JobCardCheck
    {
        public Guid Id { get; set; }
        public string Type { get; set; }
        public string TypeSubCategory { get; set; }
        public string CheckText { get; set; }
        public string ButtonType { get; set; }
        public int ListIndex { get; set; }
        public string Disabled { get; set; }
        public string NotifiableResponse { get; set; }
    }
}
