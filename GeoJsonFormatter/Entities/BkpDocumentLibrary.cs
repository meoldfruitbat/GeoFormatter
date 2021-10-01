using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class BkpDocumentLibrary
    {
        public int Id { get; set; }
        public int? FileId { get; set; }
        public string FileName { get; set; }
        public string FileTitle { get; set; }
        public bool? IPadtransferOk { get; set; }
        public string FolderPath { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public bool? IsArchived { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? IsCheckout { get; set; }
        public DateTime? Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Modified { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? Archived { get; set; }
        public string ArchivedBy { get; set; }
        public DateTime? Deleted { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? CheckedOut { get; set; }
        public string CheckedOutBy { get; set; }
    }
}
