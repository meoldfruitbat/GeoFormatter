using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class PpeRequisition
    {
        public long Id { get; set; }
        public string ProjectName { get; set; }
        public string ProjectAddress { get; set; }
        public string Cnumber { get; set; }
        public string CompletedBy { get; set; }
        public string Description { get; set; }
        public string Size { get; set; }
        public int Qty { get; set; }
        public string DateRequired { get; set; }
        public string AdditionalInformation { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public DateTime DateSubmitted { get; set; }
    }
}
