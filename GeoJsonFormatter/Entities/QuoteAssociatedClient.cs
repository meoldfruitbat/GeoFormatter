using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class QuoteAssociatedClient
    {
        public long Id { get; set; }
        public long? QuoteId { get; set; }
        public long? ClientCompanyId { get; set; }
        public long? Clientd { get; set; }
        public bool? IsPrimaryContact { get; set; }

        public virtual ClientCompanyFile ClientCompany { get; set; }
        public virtual ClientsFile ClientdNavigation { get; set; }
        public virtual QuoteFile Quote { get; set; }
    }
}
