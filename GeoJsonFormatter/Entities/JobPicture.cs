using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class JobPicture
    {
        public long Id { get; set; }
        public DateTime DateTaken { get; set; }
        public string ContractReference { get; set; }
        public long GangLeaderId { get; set; }
        public string PictureFileName { get; set; }
        public string Comments { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string PictureReason { get; set; }
        public long? SupervisorId { get; set; }
        public string LateralMeasure { get; set; }
        public string PictureCompressedFileName { get; set; }
        public string Title { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? DeletedOn { get; set; }
        public byte[] Timestamp { get; set; }
        public bool? IsVisibleToCp { get; set; }
        public string FromAddress { get; set; }
        public string ToAddress { get; set; }
        public string ResponseId { get; set; }
        public Guid? Identifier { get; set; }
        public string Category { get; set; }
        public string QuestionId { get; set; }
        public string StreetName { get; set; }
        public Guid? AssignmentId { get; set; }
        public int RotatedDegree { get; set; }
        public long? Qnumber { get; set; }
        public long? OperativeId { get; set; }
        public string OperativeRole { get; set; }
        public string PicturePath { get; set; }
    }
}
