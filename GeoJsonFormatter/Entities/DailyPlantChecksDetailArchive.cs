using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class DailyPlantChecksDetailArchive
    {
        public long Id { get; set; }
        public string ContractReference { get; set; }
        public DateTime RelevantDate { get; set; }
        public string GangLeaderName { get; set; }
        public string PlantId { get; set; }
        public string QuestionResponse { get; set; }
        public DateTime DateTimeOfCheck { get; set; }
        public string QuestionId { get; set; }
        public string PlantCheckedByName { get; set; }
        public string PlantAssignedToName { get; set; }
        public string Comments { get; set; }
        public string PictureFileName { get; set; }
        public string SignatureFileName { get; set; }
        public string CheckSubmittedBy { get; set; }
        public string Location { get; set; }
    }
}
