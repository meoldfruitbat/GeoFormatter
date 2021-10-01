using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class PlanningGeneralAnswer
    {
        public long Id { get; set; }
        public long? Qnumber { get; set; }
        public int? QuestionNumber { get; set; }
        public string YesOrNo { get; set; }
        public string Comments { get; set; }
        public DateTime? DateTimePosted { get; set; }
        public string PostedBy { get; set; }
        public int? PlanningGeneralQuestionId { get; set; }

        public virtual PlanningGeneralQuestion PlanningGeneralQuestion { get; set; }
    }
}
