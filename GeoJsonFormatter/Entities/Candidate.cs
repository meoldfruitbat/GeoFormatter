using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class Candidate
    {
        public Candidate()
        {
            CandidateDocs = new HashSet<CandidateDoc>();
            CandidateEmails = new HashSet<CandidateEmail>();
            CandidateExperiences = new HashSet<CandidateExperience>();
            CandidatePhoneCalls = new HashSet<CandidatePhoneCall>();
            InterviewCandidateLists = new HashSet<InterviewCandidateList>();
            VacancyShortLists = new HashSet<VacancyShortList>();
        }

        public int Id { get; set; }
        public string CandidateReference { get; set; }
        public int? Title { get; set; }
        public string Forename { get; set; }
        public string Surname { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string Postcode { get; set; }
        public int? Nationality { get; set; }
        public string PrimaryContactNo { get; set; }
        public string SecondaryContactNo { get; set; }
        public string Email { get; set; }
        public DateTime? Dob { get; set; }
        public int? Gender { get; set; }
        public string Ninumber { get; set; }
        public decimal? SalaryRangeFrom { get; set; }
        public decimal? SalaryRangeTo { get; set; }
        public string NextOfKinName { get; set; }
        public string NextOfKinContactNumber { get; set; }
        public string NextOfKinRelationship { get; set; }
        public string Keywords { get; set; }
        public int Status { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public byte[] Timestamp { get; set; }
        public string Education { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string MiddleName { get; set; }
        public string Notes { get; set; }
        public string Vocation { get; set; }
        public string SecondaryVocation { get; set; }
        public int? SubStatus { get; set; }
        public string Comments { get; set; }
        public DateTime? AvailableFrom { get; set; }
        public string Cvfilepath { get; set; }

        public virtual NationalityLookup NationalityNavigation { get; set; }
        public virtual ICollection<CandidateDoc> CandidateDocs { get; set; }
        public virtual ICollection<CandidateEmail> CandidateEmails { get; set; }
        public virtual ICollection<CandidateExperience> CandidateExperiences { get; set; }
        public virtual ICollection<CandidatePhoneCall> CandidatePhoneCalls { get; set; }
        public virtual ICollection<InterviewCandidateList> InterviewCandidateLists { get; set; }
        public virtual ICollection<VacancyShortList> VacancyShortLists { get; set; }
    }
}
