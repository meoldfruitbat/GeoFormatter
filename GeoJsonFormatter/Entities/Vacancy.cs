using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class Vacancy
    {
        public Vacancy()
        {
            InterviewCandidateLists = new HashSet<InterviewCandidateList>();
            VacancyAdvertisings = new HashSet<VacancyAdvertising>();
            VacancyShortLists = new HashSet<VacancyShortList>();
        }

        public int Id { get; set; }
        public string VacancyReference { get; set; }
        public string Title { get; set; }
        public string Location { get; set; }
        public int Status { get; set; }
        public string RoleType { get; set; }
        public string SalaryType { get; set; }
        public string PayFrequency { get; set; }
        public DateTime? ClosingDate { get; set; }
        public string Keywords { get; set; }
        public string FeesProposal { get; set; }
        public decimal? SalaryFrom { get; set; }
        public decimal? SalaryTo { get; set; }
        public decimal? TargetSalary { get; set; }
        public string Benefits { get; set; }
        public long? ClientCompanyId { get; set; }
        public long? ContactId { get; set; }
        public bool SpeculativeAdvert { get; set; }
        public string TheirReference { get; set; }
        public string OurReference { get; set; }
        public string InterviewProcess { get; set; }
        public string Interviewer1 { get; set; }
        public string Interviewer2 { get; set; }
        public string InterviewAddress1 { get; set; }
        public string InterviewAddress2 { get; set; }
        public string InterviewCity { get; set; }
        public string InterviewCounty { get; set; }
        public string InterviewPostcode { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public byte[] Timestamp { get; set; }
        public string PostCode { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public int? NumberOfVacancies { get; set; }
        public string Interviewer3 { get; set; }
        public int? SubStatus { get; set; }
        public string Comments { get; set; }
        public long? VacancyConsultant { get; set; }

        public virtual ClientsFile Contact { get; set; }
        public virtual ICollection<InterviewCandidateList> InterviewCandidateLists { get; set; }
        public virtual ICollection<VacancyAdvertising> VacancyAdvertisings { get; set; }
        public virtual ICollection<VacancyShortList> VacancyShortLists { get; set; }
    }
}
