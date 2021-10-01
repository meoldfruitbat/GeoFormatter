using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class CandidateTraining
    {
        public int Id { get; set; }
        public int RecruitmentTrainingId { get; set; }
        public int CandidateId { get; set; }
    }
}
