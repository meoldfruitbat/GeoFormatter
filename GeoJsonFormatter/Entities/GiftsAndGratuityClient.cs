using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class GiftsAndGratuityClient
    {
        public long Id { get; set; }
        public string Gagid { get; set; }
        public string ClientId { get; set; }
        public bool Authorised { get; set; }
        public string AuthorisationInfo { get; set; }
        public bool? Accepted { get; set; }
        public bool? Attended { get; set; }
    }
}
