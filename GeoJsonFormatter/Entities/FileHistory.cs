using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class FileHistory
    {
        public int Id { get; set; }
        public int? FileId { get; set; }
        public string FileName { get; set; }
        public string Path { get; set; }
        public decimal? Version { get; set; }
        public string VersionComments { get; set; }
        public string CommentsAddedBy { get; set; }
        public DateTime? CommentsAddedDate { get; set; }
        public bool? IsCurrentVersion { get; set; }
    }
}
