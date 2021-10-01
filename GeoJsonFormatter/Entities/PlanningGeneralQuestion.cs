using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class PlanningGeneralQuestion
    {
        public PlanningGeneralQuestion()
        {
            PlanningGeneralAnswers = new HashSet<PlanningGeneralAnswer>();
        }

        public int Id { get; set; }
        public int? QuestionNumber { get; set; }
        public string QuestionText { get; set; }
        public string Active { get; set; }

        public virtual ICollection<PlanningGeneralAnswer> PlanningGeneralAnswers { get; set; }
    }
}
