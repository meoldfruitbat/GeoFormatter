using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class MeasuresExceeded
    {
        public long Id { get; set; }
        public string ContractReference { get; set; }
        public DateTime? MeasuresExceededDate { get; set; }
        public string SalesPerson { get; set; }
        public string SalesPersonEmail { get; set; }
        public string ProjectName { get; set; }
        public string ClientName { get; set; }
        public string GangLeader { get; set; }
        public string Measure { get; set; }
        public string BaseUnit { get; set; }
        public string Planned { get; set; }
        public string LeftToDo { get; set; }
        public string CompletedThisDay { get; set; }
        public DateTime? EmailCheck { get; set; }
    }
}
