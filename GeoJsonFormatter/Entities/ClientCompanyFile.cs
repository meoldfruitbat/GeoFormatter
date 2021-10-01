using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class ClientCompanyFile
    {
        public ClientCompanyFile()
        {
            ClientsFiles = new HashSet<ClientsFile>();
            ItemStockTransferHistoryTransferFromNavigations = new HashSet<ItemStockTransferHistory>();
            ItemStockTransferHistoryTransferToNavigations = new HashSet<ItemStockTransferHistory>();
            ItemStocks = new HashSet<ItemStock>();
            ItemSuppliers = new HashSet<ItemSupplier>();
            OperativeFiles = new HashSet<OperativeFile>();
            Orders = new HashSet<Order>();
            PriceEnquirySuppliers = new HashSet<PriceEnquirySupplier>();
            QuoteAssociatedClients = new HashSet<QuoteAssociatedClient>();
            SupplierDetailReferences = new HashSet<SupplierDetailReference>();
            SupplierDetails = new HashSet<SupplierDetail>();
        }

        public long CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAddress01 { get; set; }
        public string CompanyAddress02 { get; set; }
        public string CompanyAddress03 { get; set; }
        public string CompanyAddress04 { get; set; }
        public string CompanyPostcode { get; set; }
        public string CompanyCity { get; set; }
        public string CompanyCounty { get; set; }
        public string CompanyCountry { get; set; }
        public string CompanyOffice { get; set; }
        public string CompanyFax { get; set; }
        public string CompanyEmail { get; set; }
        public string CompanyWww { get; set; }
        public string CompanyIndustry { get; set; }
        public string CompanyNotes { get; set; }
        public string CompanyEmailDisplayName { get; set; }
        public string SupplierFlag { get; set; }
        public string DisableAccount { get; set; }
        public string SupplierIndustry { get; set; }
        public string AccountNo { get; set; }
        public string UtilityCompanyType { get; set; }
        public string TrainingProvider { get; set; }
        public string ClientAccount { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public long? ParentCompanyId { get; set; }
        public string OfficeTitle { get; set; }
        public short? CompanyTypeId { get; set; }
        public long? BillingOfficeId { get; set; }
        public string CompanyRegNo { get; set; }
        public bool? IsSubContractorAccount { get; set; }
        public bool? IsVatregistered { get; set; }
        public string Vatno { get; set; }
        public string Cisno { get; set; }
        public string Utrno { get; set; }
        public string PubLiabilityIncNo { get; set; }
        public DateTime? PubLiabilityIncExpiryDate { get; set; }
        public string ProfIndemnityIncNo { get; set; }
        public DateTime? ProfIndemnityIncExpiryDate { get; set; }
        public string ContractorsLiabilityIncNo { get; set; }
        public DateTime? ContractorsLiabilityIncExpiryDate { get; set; }
        public string EmployerLiabilityIncNo { get; set; }
        public DateTime? EmployerLiabilityIncExpiryDate { get; set; }
        public bool? IsAccountSuspended { get; set; }
        public bool? IsUtilityCompany { get; set; }
        public string CompanyLogo { get; set; }
        public string CompanyGuid { get; set; }

        public virtual ICollection<ClientsFile> ClientsFiles { get; set; }
        public virtual ICollection<ItemStockTransferHistory> ItemStockTransferHistoryTransferFromNavigations { get; set; }
        public virtual ICollection<ItemStockTransferHistory> ItemStockTransferHistoryTransferToNavigations { get; set; }
        public virtual ICollection<ItemStock> ItemStocks { get; set; }
        public virtual ICollection<ItemSupplier> ItemSuppliers { get; set; }
        public virtual ICollection<OperativeFile> OperativeFiles { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<PriceEnquirySupplier> PriceEnquirySuppliers { get; set; }
        public virtual ICollection<QuoteAssociatedClient> QuoteAssociatedClients { get; set; }
        public virtual ICollection<SupplierDetailReference> SupplierDetailReferences { get; set; }
        public virtual ICollection<SupplierDetail> SupplierDetails { get; set; }
    }
}
