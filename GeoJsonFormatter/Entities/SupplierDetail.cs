using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class SupplierDetail
    {
        public SupplierDetail()
        {
            SupplierDetailReferences = new HashSet<SupplierDetailReference>();
        }

        public int Id { get; set; }
        public long CompanyId { get; set; }
        public string PurchaseOrderName { get; set; }
        public string PurchaseOrderEmail { get; set; }
        public string PurchaseOrderTelephone { get; set; }
        public string RemittanceName { get; set; }
        public string RemittanceEmail { get; set; }
        public string RemittanceTelephone { get; set; }
        public bool AcceptCreditCardPayment { get; set; }
        public decimal? PercentageCharge { get; set; }
        public string BankBranchName { get; set; }
        public string BankBranchAddress { get; set; }
        public string BankAccountName { get; set; }
        public string BankAccountSortCode { get; set; }
        public string BankAccountNumber { get; set; }
        public bool SpeciallyApprovedToClient { get; set; }
        public int Approval { get; set; }
        public byte[] TimeStamp { get; set; }
        public bool QuestionarieReceived { get; set; }
        public bool? ProductTypeApplicable { get; set; }
        public bool? WorkstreamApplicable { get; set; }

        public virtual ReferenceDatum ApprovalNavigation { get; set; }
        public virtual ClientCompanyFile Company { get; set; }
        public virtual ICollection<SupplierDetailReference> SupplierDetailReferences { get; set; }
    }
}
