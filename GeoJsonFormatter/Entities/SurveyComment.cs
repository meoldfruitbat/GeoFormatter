using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class SurveyComment
    {
        public SurveyComment()
        {
            SurveyCommentLogs = new HashSet<SurveyCommentLog>();
        }

        public int Id { get; set; }
        public Guid Identifier { get; set; }
        public string Text { get; set; }
        public string StreetName { get; set; }
        public string ToAddress { get; set; }
        public string FromAddress { get; set; }
        public long Qnumber { get; set; }
        public DateTime SubmittedDateTime { get; set; }
        public long CompletedById { get; set; }
        public string QuestionId { get; set; }
        public string Category { get; set; }
        public Guid AssignmentId { get; set; }
        public string WorksIdForDelete { get; set; }

        public virtual Assignment Assignment { get; set; }
        public virtual ICollection<SurveyCommentLog> SurveyCommentLogs { get; set; }
    }
}
