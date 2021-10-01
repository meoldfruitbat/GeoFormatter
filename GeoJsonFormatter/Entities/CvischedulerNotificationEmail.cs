using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class CvischedulerNotificationEmail
    {
        public int Id { get; set; }
        public long Cvino { get; set; }
        public string NotificationElementId { get; set; }
        public DateTime SentDateTime { get; set; }

        public virtual Cvi CvinoNavigation { get; set; }
    }
}
