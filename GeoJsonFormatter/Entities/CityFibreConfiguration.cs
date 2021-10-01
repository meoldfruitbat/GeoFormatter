using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class CityFibreConfiguration
    {
        public long Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ClientPurchaseOrderNumber { get; set; }
        public string FormofContract { get; set; }
        public int PaymentTerms { get; set; }
        public string ContractType { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string PaymentContactName { get; set; }
        public string PaymentMethod { get; set; }
        public string EmailAddress { get; set; }
    }
}
