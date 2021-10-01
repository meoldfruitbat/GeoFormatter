using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class OperativeDoc
    {
        public long Id { get; set; }
        public string CardRegNumber { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? ExpDate { get; set; }
        public string FileName { get; set; }
        public string CardName { get; set; }
        public string OpenText { get; set; }
        public string Active { get; set; }
        public string OperativeId { get; set; }
        public string Section { get; set; }
        public string IPadtransferOk { get; set; }
        public string TrainingProvider { get; set; }
        public decimal? TrainingCost { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public string Type { get; set; }
        public long? SupercededById { get; set; }
        public DateTime? SupercededDate { get; set; }
        public decimal? TrainingHour { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public long? DeletedBy { get; set; }
        public int? TrainingId { get; set; }
        public string TrainingSubCategory { get; set; }
        public string TrainingCertificate { get; set; }

        public virtual TrainingDetail Training { get; set; }
    }
}
