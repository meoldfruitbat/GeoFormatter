using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class ManageEmail
    {
        public long Id { get; set; }
        public int ReferenceTable { get; set; }
        public long ReferenceTablePkid { get; set; }
        public string MailTo { get; set; }
        public string MailCc { get; set; }
        public string MailBcc { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string OtherAttachments { get; set; }
        public string ProductAttachment { get; set; }
        public int Status { get; set; }
        public DateTime StatusDate { get; set; }
        public short? SentCount { get; set; }

        public virtual ReferenceDatum ReferenceTableNavigation { get; set; }
        public virtual ReferenceDatum StatusNavigation { get; set; }
    }
}
