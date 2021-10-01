using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class PriceEnquiry
    {
        public PriceEnquiry()
        {
            PriceEnquiryItemTypes = new HashSet<PriceEnquiryItemType>();
            PriceEnquirySuppliers = new HashSet<PriceEnquirySupplier>();
        }

        public int Id { get; set; }
        public int PriceFor { get; set; }
        public long? ProjectId { get; set; }
        public bool IsForQuoteOrContract { get; set; }
        public string DelieveryAddress { get; set; }
        public DateTime? RequiredByDate { get; set; }
        public string EnquiryName { get; set; }
        public string OtherEmails { get; set; }
        public string EmailBody { get; set; }
        public string EmailAttachments { get; set; }
        public string ProductAttachments { get; set; }

        public virtual ContractFile Project { get; set; }
        public virtual ICollection<PriceEnquiryItemType> PriceEnquiryItemTypes { get; set; }
        public virtual ICollection<PriceEnquirySupplier> PriceEnquirySuppliers { get; set; }
    }
}
