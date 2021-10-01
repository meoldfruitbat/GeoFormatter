using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class FileDownloadControl
    {
        public long FileDownLoadId { get; set; }
        public string ExtranetLogonReason { get; set; }
        public DateTime? WhenEnabled { get; set; }
        public int? HowLongToBeEnabled { get; set; }
        public string LogonHours { get; set; }
        public string LogonDays { get; set; }
        public string CompanySelected { get; set; }
        public string Active { get; set; }
    }
}
