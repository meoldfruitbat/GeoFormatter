using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class SurveyQuestion
    {
        public int Id { get; set; }
        public decimal? QuestionId { get; set; }
        public string Grouping { get; set; }
        public string Stage { get; set; }
        public string Question { get; set; }
        public string KeyAnswer { get; set; }
        public decimal? FurtherQuestionId { get; set; }
        public string ResponseType { get; set; }
        public string QuestionOptions { get; set; }
        public bool? NotifiableResponse { get; set; }
        public string InformationTo { get; set; }
        public string Category { get; set; }
        public string FollowUpAction { get; set; }
        public decimal? DepthorRating { get; set; }
        public string AvailableToContract { get; set; }
        public string Report { get; set; }
    }
}
