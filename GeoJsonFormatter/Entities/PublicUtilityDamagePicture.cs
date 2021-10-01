using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class PublicUtilityDamagePicture
    {
        public int Id { get; set; }
        public long PublicUtilityDamageId { get; set; }
        public string Filename { get; set; }
        public string Comments { get; set; }
        public bool Active { get; set; }
        public DateTime Date { get; set; }
        public int? InvestigationId { get; set; }
        public long? UploadedBy { get; set; }
        public string Title { get; set; }
        public string PictureCompressedFileName { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedOn { get; set; }
        public byte[] Timestamp { get; set; }
        public int RotatedDegree { get; set; }
        public bool? IsFinal { get; set; }

        public virtual PublicUtilityDamage PublicUtilityDamage { get; set; }
    }
}
