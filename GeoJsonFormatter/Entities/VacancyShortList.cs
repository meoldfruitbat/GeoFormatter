using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class VacancyShortList
    {
        public int Id { get; set; }
        public int CandidateId { get; set; }
        public int VacancyId { get; set; }
        public DateTime ShortlistedDate { get; set; }
        public long ShortlistedBy { get; set; }
        public int Status { get; set; }
        public string Feedback { get; set; }

        public virtual Candidate Candidate { get; set; }
        public virtual Vacancy Vacancy { get; set; }
    }
}
