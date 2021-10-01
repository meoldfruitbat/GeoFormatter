using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class SurveyCommentLog
    {
        public int Id { get; set; }
        public int SurveyCommentId { get; set; }
        public DateTime CommentDate { get; set; }
        public string Identifier { get; set; }
        public long CommentedBy { get; set; }

        public virtual SurveyComment SurveyComment { get; set; }
    }
}
