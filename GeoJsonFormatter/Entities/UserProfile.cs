using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class UserProfile
    {
        public long Id { get; set; }
        public long OperativeId { get; set; }
        public string Application { get; set; }
        public bool Administrator { get; set; }
        public bool FullControl { get; set; }
        public bool CanRead { get; set; }
        public bool CanWrite { get; set; }
    }
}
