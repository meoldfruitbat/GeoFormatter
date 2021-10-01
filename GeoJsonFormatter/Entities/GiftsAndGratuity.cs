using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class GiftsAndGratuity
    {
        public long Id { get; set; }
        public string CompanyId { get; set; }
        public string EventType { get; set; }
        public double AmountPerPerson { get; set; }
        public bool Under50Pounds { get; set; }
        public string EventDescription { get; set; }
        public string Originator { get; set; }
        public DateTime DateEntered { get; set; }
        public DateTime LastAmendedOn { get; set; }
        public bool Authorised { get; set; }
        public string AuthorisedBy { get; set; }
        public DateTime? EventStartDate { get; set; }
        public DateTime? EventEndDate { get; set; }
        public string AuthorisationInfo { get; set; }
        public double? ActualAmountPerPerson { get; set; }
    }
}
