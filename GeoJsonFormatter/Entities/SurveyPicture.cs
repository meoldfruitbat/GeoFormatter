using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class SurveyPicture
    {
        public int Id { get; set; }
        public DateTime TimeTaken { get; set; }
        public string Qnumber { get; set; }
        public string OperativeId { get; set; }
        public string OperativeRole { get; set; }
        public string FileName { get; set; }
        public string Lattitude { get; set; }
        public string Longitude { get; set; }
        public string Reason { get; set; }
        public string Path { get; set; }
        public string FromAddress { get; set; }
        public string ToAddress { get; set; }
        public decimal? ResponseId { get; set; }
        public string DfeId { get; set; }
        public string Category { get; set; }
        public string StreetName { get; set; }
        public decimal? QuestionId { get; set; }
        public string AssignmentId { get; set; }
        public string DiaryId { get; set; }
    }
}
