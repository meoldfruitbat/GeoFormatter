using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class Cvipicture
    {
        public long Id { get; set; }
        public DateTime? DateTaken { get; set; }
        public long? Cvino { get; set; }
        public string Title { get; set; }
        public string PictureFileName { get; set; }
        public string PictureCompressedFileName { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string Comments { get; set; }
        public long? UploadedBy { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedOn { get; set; }
        public byte[] Timestamp { get; set; }
        public int RotatedDegree { get; set; }
        public Guid? Cviid { get; set; }

        public virtual Cvi CvinoNavigation { get; set; }
    }
}
