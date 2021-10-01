using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class AcceptTransferDatum
    {
        public long PtcId { get; set; }
        public string TransferCommentsIn { get; set; }
        public string Pic1FilenameIn { get; set; }
        public string Pic2FilenameIn { get; set; }
        public string Pic3FilenameIn { get; set; }
        public string Pic4FilenameIn { get; set; }
    }
}
