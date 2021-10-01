using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class ExtranetFilesToDownload
    {
        public long DownloadFileId { get; set; }
        public string DownloadRequestId { get; set; }
        public string FileName { get; set; }
        public DateTime? LastUpdate { get; set; }
        public string Active { get; set; }
        public string FileDescription { get; set; }
    }
}
