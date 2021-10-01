using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class TrainingDetail
    {
        public TrainingDetail()
        {
            OperativeDocs = new HashSet<OperativeDoc>();
        }

        public int Id { get; set; }
        public string TrainingName { get; set; }
        public string TrainingFor { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Attendees { get; set; }
        public string Comments { get; set; }
        public string OrganizedBy { get; set; }
        public string TrainingStatus { get; set; }
        public decimal? TrainingCost { get; set; }
        public string TrainingSubCategory { get; set; }
        public string TrainingCertificate { get; set; }

        public virtual ICollection<OperativeDoc> OperativeDocs { get; set; }
    }
}
