using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class InHouseFailureImage
    {
        public Guid Id { get; set; }
        public long InHouseFailureId { get; set; }
        public string FileName { get; set; }
        public string Extension { get; set; }
        public string MimeType { get; set; }
        public long Size { get; set; }
        public DateTime DateTaken { get; set; }
    }
}
