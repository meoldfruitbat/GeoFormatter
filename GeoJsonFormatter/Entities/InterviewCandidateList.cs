using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class InterviewCandidateList
    {
        public int Id { get; set; }
        public int? CandidateId { get; set; }
        public int? VacancyId { get; set; }
        public string Location { get; set; }
        public string InterviewerOne { get; set; }
        public string InterviewerTwo { get; set; }
        public string InterviewerThree { get; set; }
        public DateTime? InterviewDate { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? InterviewEndDateTime { get; set; }

        public virtual Candidate Candidate { get; set; }
        public virtual Vacancy Vacancy { get; set; }
    }
}
