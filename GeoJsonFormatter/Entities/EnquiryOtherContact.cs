using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class EnquiryOtherContact
    {
        public long Id { get; set; }
        public long? LeadId { get; set; }
        public long? ClientId { get; set; }
        public bool? IsDecisionMaker { get; set; }
        public long? QuoteId { get; set; }

        public virtual ClientsFile Client { get; set; }
        public virtual Lead Lead { get; set; }
    }
}
