using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class ValuationDetail
    {
        public int ValuationId { get; set; }
        public long? MainContractId { get; set; }
        public DateTime? DateOfSubmission { get; set; }
        public decimal? Value { get; set; }
        public DateTime? DatePaymentExpected { get; set; }
        public DateTime? DateOfActualPayment { get; set; }
        public decimal? PaymentAmount { get; set; }
        public decimal? Difference { get; set; }
        public string PaymentReference { get; set; }
        public DateTime? CreatedOn { get; set; }

        public virtual ContractFile MainContract { get; set; }
    }
}
