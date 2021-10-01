﻿using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class EmailAttachment
    {
        public long Id { get; set; }
        public long EmailId { get; set; }
        public string MimeType { get; set; }
        public long FileSize { get; set; }
        public byte[] Attachment { get; set; }
        public string FileName { get; set; }
    }
}
