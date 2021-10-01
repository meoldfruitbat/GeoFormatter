using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class ToolBoxTalk
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string FullName { get; set; }
        public string Frequency { get; set; }
        public string FileName { get; set; }
        public string Version { get; set; }
        public DateTime? DateOfUpload { get; set; }
        public string TrainingProvider { get; set; }
        public string TrainingType { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DateLastDistributed { get; set; }
    }
}
