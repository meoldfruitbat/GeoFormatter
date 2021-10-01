using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class DefaultFolderStructure
    {
        public int Id { get; set; }
        public string Container { get; set; }
        public string Folder { get; set; }
        public int? ParentId { get; set; }
        public bool IsDeleted { get; set; }
        public string ConfigType { get; set; }
        public DateTime? Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Modified { get; set; }
        public string ModifiedBy { get; set; }
        public string FolderPath { get; set; }
        public bool? IsRenameAllowed { get; set; }
        public bool? IsDeletedAllowed { get; set; }
        public bool? IsMobile { get; set; }
    }
}
