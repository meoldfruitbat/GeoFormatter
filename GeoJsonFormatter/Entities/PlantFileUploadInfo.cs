using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class PlantFileUploadInfo
    {
        public long Id { get; set; }
        public string PlantId { get; set; }
        public string FileName { get; set; }
        public string Active { get; set; }
        public string IsItAfolder { get; set; }
        public string FolderPath { get; set; }
        public long? Ticket { get; set; }
        public DateTime? UploadDateTime { get; set; }
        public string DocumentTitle { get; set; }
    }
}
