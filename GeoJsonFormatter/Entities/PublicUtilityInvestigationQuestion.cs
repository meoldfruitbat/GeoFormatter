using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class PublicUtilityInvestigationQuestion
    {
        public PublicUtilityInvestigationQuestion()
        {
            PublicUtilityInvestigationAnswers = new HashSet<PublicUtilityInvestigationAnswer>();
        }

        public int Id { get; set; }
        public string Question { get; set; }
        public int? MultiChoiceCategoryId { get; set; }
        public bool? IsNewQuestion { get; set; }
        public int? QuestionOrder { get; set; }
        public string Category { get; set; }

        public virtual ICollection<PublicUtilityInvestigationAnswer> PublicUtilityInvestigationAnswers { get; set; }
    }
}
