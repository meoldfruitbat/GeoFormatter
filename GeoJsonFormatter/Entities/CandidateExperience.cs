using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class CandidateExperience
    {
        public int Id { get; set; }
        public int CandidateId { get; set; }
        public string EmployerName { get; set; }
        public string Role { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Desciption { get; set; }
        public decimal? Salary { get; set; }
        public byte[] Timestamp { get; set; }
        public string ReferenceName { get; set; }
        public string ReferenceContactNo { get; set; }
        public string ReferenceEmail { get; set; }
        public int? VacancyId { get; set; }

        public virtual Candidate Candidate { get; set; }
    }
}
