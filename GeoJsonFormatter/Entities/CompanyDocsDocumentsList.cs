using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class CompanyDocsDocumentsList
    {
        public int Id { get; set; }
        public string Filename { get; set; }
        public string IsItAfolder { get; set; }
        public string Path { get; set; }
        public string WhoIsItFor { get; set; }
    }
}
