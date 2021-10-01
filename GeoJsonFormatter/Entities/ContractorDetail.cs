using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class ContractorDetail
    {
        public ContractorDetail()
        {
            ContractorDetailReferences = new HashSet<ContractorDetailReference>();
        }

        public long Id { get; set; }
        public long ContractorId { get; set; }
        public string PurchaseOrderName { get; set; }
        public string PurchaseOrderEmail { get; set; }
        public string PurchaseOrderTelephone { get; set; }
        public string RemittanceName { get; set; }
        public string RemittanceEmail { get; set; }
        public string RemittanceTelephone { get; set; }
        public bool AcceptCreditCardPayment { get; set; }
        public bool IsRetentionApplied { get; set; }
        public decimal? PercentageCharge { get; set; }
        public string BankBranchName { get; set; }
        public string BankBranchAddress { get; set; }
        public string BankAccountName { get; set; }
        public string BankAccountSortCode { get; set; }
        public string BankAccountNumber { get; set; }
        public string PubLiabilityIncNo { get; set; }
        public DateTime? PubLiabilityIncExpiryDate { get; set; }
        public string ProfIndemnityIncNo { get; set; }
        public DateTime? ProfIndemnityIncExpiryDate { get; set; }
        public string ContractorsLiabilityIncNo { get; set; }
        public DateTime? ContractorsLiabilityIncExpiryDate { get; set; }
        public string EmployerLiabilityIncNo { get; set; }
        public DateTime? EmployerLiabilityIncExpiryDate { get; set; }
        public int Approval { get; set; }
        public bool QuestionarieReceived { get; set; }
        public bool TradeDetailsApplicable { get; set; }
        public bool RegionApplicable { get; set; }
        public byte[] TimeStamp { get; set; }
        public string TimestampTrade { get; set; }

        public virtual ReferenceDatum ApprovalNavigation { get; set; }
        public virtual ClientContractorFile Contractor { get; set; }
        public virtual ICollection<ContractorDetailReference> ContractorDetailReferences { get; set; }
    }
}
