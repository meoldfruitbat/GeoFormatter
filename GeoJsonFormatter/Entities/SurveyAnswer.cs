using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class SurveyAnswer
    {
        public int Id { get; set; }
        public decimal QuestionId { get; set; }
        public string AnswerGiven { get; set; }
        public string StreetName { get; set; }
        public string Comments { get; set; }
        public string CompletedById { get; set; }
        public string LocationName { get; set; }
        public long Qnumber { get; set; }
        public bool Notifiable { get; set; }
        public DateTime SubmittedDateTime { get; set; }
        public string Category { get; set; }
        public Guid? AssignmentId { get; set; }
        public decimal? Rating { get; set; }
        public Guid? Identifier { get; set; }
        public string AppStatus { get; set; }

        public virtual Assignment Assignment { get; set; }
    }
}
