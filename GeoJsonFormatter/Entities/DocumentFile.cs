using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class DocumentFile
    {
        public string DocId { get; set; }
        public string ContractReference { get; set; }
        public long? QuoteId { get; set; }
        public string ConPrefix { get; set; }
        public string ContractId { get; set; }
        public string DocName { get; set; }
        public string DocPath { get; set; }
        public string DocType { get; set; }
        public string DocBlob { get; set; }
    }
}
