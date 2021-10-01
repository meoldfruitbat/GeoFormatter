using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class CompanySetup
    {
        public CompanySetup()
        {
            AliasTypes = new HashSet<AliasType>();
            CompanyDomains = new HashSet<CompanyDomain>();
        }

        public int CompanyId { get; set; }
        public string Logo { get; set; }
        public string CompanyName { get; set; }
        public string EmailAddress { get; set; }
        public string ErrorEmail { get; set; }
        public string EmailHeader { get; set; }
        public string CompanyAddress { get; set; }
        public string EmailFooter { get; set; }
        public byte AccessType { get; set; }
        public byte AuthenticationType { get; set; }
        public byte Pim { get; set; }
        public int ColumnWidth { get; set; }
        public int RowWidth { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? AttachmentSize { get; set; }

        public virtual ICollection<AliasType> AliasTypes { get; set; }
        public virtual ICollection<CompanyDomain> CompanyDomains { get; set; }
    }
}
