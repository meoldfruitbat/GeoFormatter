using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class Assignment
    {
        public Assignment()
        {
            Abmeasures = new HashSet<Abmeasure>();
            Audits = new HashSet<Audit>();
            Cvis = new HashSet<Cvi>();
            DigPermits = new HashSet<DigPermit>();
            Dves = new HashSet<Dfe>();
            SurveyAnswers = new HashSet<SurveyAnswer>();
            SurveyComments = new HashSet<SurveyComment>();
        }

        public int Id { get; set; }
        public Guid AssignmentId { get; set; }
        public string LocationName { get; set; }
        public string LocationId { get; set; }
        public long Qnumber { get; set; }
        public DateTime SubmittedDateTime { get; set; }
        public string ClientName { get; set; }
        public string ProjectName { get; set; }
        public string Category { get; set; }
        public string Complete { get; set; }
        public string StreetName { get; set; }
        public long? TermContract { get; set; }

        public virtual ICollection<Abmeasure> Abmeasures { get; set; }
        public virtual ICollection<Audit> Audits { get; set; }
        public virtual ICollection<Cvi> Cvis { get; set; }
        public virtual ICollection<DigPermit> DigPermits { get; set; }
        public virtual ICollection<Dfe> Dves { get; set; }
        public virtual ICollection<SurveyAnswer> SurveyAnswers { get; set; }
        public virtual ICollection<SurveyComment> SurveyComments { get; set; }
    }
}
