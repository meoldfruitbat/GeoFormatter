using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class PriceEnquirySupplier
    {
        public PriceEnquirySupplier()
        {
            ProductEnquiries = new HashSet<ProductEnquiry>();
        }

        public int Id { get; set; }
        public int PriceEnquiryId { get; set; }
        public long SupplierId { get; set; }
        public DateTime? EntryDate { get; set; }
        public string LeadTime { get; set; }
        public string Notes { get; set; }
        public DateTime? RespondedDate { get; set; }
        public decimal? CheapPercentage { get; set; }
        public int? Rank { get; set; }
        public string ProductAttachment { get; set; }

        public virtual PriceEnquiry PriceEnquiry { get; set; }
        public virtual ClientCompanyFile Supplier { get; set; }
        public virtual ICollection<ProductEnquiry> ProductEnquiries { get; set; }
    }
}
