using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class VersionDetail
    {
        public int Id { get; set; }
        public string Feature { get; set; }
        public string FolderName { get; set; }
        public string FileName { get; set; }
        public DateTime? DeployedOn { get; set; }
        public bool? IsExecutedSuccessfully { get; set; }
    }
}
