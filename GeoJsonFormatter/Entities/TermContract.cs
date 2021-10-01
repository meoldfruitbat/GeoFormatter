using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class TermContract
    {
        public long Id { get; set; }
        public string Tcname { get; set; }
        public string Enabled { get; set; }
        public string CompanyId { get; set; }
        public string ClientId { get; set; }
        public string ContractRootId { get; set; }
        public string SharedFolderPath { get; set; }
    }
}
