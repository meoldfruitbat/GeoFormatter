using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class Fitter
    {
        public long Id { get; set; }
        public long OperativeId { get; set; }
        public bool TabActive { get; set; }
        public string ColourCode { get; set; }
        public string TagTextColour { get; set; }
    }
}
