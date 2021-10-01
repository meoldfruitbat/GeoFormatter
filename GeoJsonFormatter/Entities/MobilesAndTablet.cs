using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class MobilesAndTablet
    {
        public long Id { get; set; }
        public string UserId { get; set; }
        public string DeviceType { get; set; }
        public string DeviceMake { get; set; }
        public string DeviceModel { get; set; }
        public string Imei { get; set; }
        public string MobileNo { get; set; }
        public string Simnumber { get; set; }
        public string Passcode { get; set; }
        public DateTime? DateAssigned { get; set; }
        public DateTime? DateReturned { get; set; }
    }
}
