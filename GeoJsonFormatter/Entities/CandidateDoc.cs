using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class CandidateDoc
    {
        public int Id { get; set; }
        public int CandidateId { get; set; }
        public string CardRegNumber { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string FileName { get; set; }
        public string CardName { get; set; }
        public string OpenText { get; set; }
        public string Active { get; set; }
        public string Section { get; set; }
        public bool IPadtransferOk { get; set; }
        public string TrainingProvider { get; set; }
        public decimal? TrainingCost { get; set; }
        public long LastModifiedBy { get; set; }
        public DateTime LastModifiedOn { get; set; }
        public string Type { get; set; }
        public long? SupercededById { get; set; }
        public DateTime? SupercededDate { get; set; }

        public virtual Candidate Candidate { get; set; }
    }
}
