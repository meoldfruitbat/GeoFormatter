using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class CandidateProfile
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Forename { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
        public string MobileNumber { get; set; }
        public string GangOrPerson { get; set; }
        public string Tickets { get; set; }
        public string PreviousEmployment { get; set; }
        public string Role { get; set; }
        public string Notes { get; set; }
        public string PreviousReferences { get; set; }
        public DateTime? Dob { get; set; }
        public DateTime? DateTimeLogged { get; set; }
        public string LoggedBy { get; set; }
        public string Active { get; set; }
        public string Scdnotes { get; set; }
    }
}
