using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class ContractFile
    {
        public ContractFile()
        {
            OperationDetails = new HashSet<OperationDetail>();
            Orders = new HashSet<Order>();
            PlantRequestDetails = new HashSet<PlantRequestDetail>();
            PriceEnquiries = new HashSet<PriceEnquiry>();
            ProjectCheckIndicators = new HashSet<ProjectCheckIndicator>();
            ProjectLabourRequirements = new HashSet<ProjectLabourRequirement>();
            ProjectSheqs = new HashSet<ProjectSheq>();
            ValuationDetails = new HashSet<ValuationDetail>();
        }

        public long MainContractId { get; set; }
        public string ContractReference { get; set; }
        public long? QuoteId { get; set; }
        public long? ContractId { get; set; }
        public string WorkId { get; set; }
        public string VariationId { get; set; }
        public string ClientId { get; set; }
        public string QuoteYear { get; set; }
        public string QuotePrefix { get; set; }
        public string ContractPrefix { get; set; }
        public string WorkPrefix { get; set; }
        public string VariationPrefix { get; set; }
        public DateTime? ConCreated { get; set; }
        public string ConValue { get; set; }
        public string ConPorder { get; set; }
        public string ConIssuedby { get; set; }
        public string ConTheirref { get; set; }
        public string ConStatus { get; set; }
        public DateTime? ConStart { get; set; }
        public DateTime? ConEnd { get; set; }
        public string ProjectName { get; set; }
        public string ConLocation01 { get; set; }
        public string ConLocation02 { get; set; }
        public string ConLocation03 { get; set; }
        public string ConLocation04 { get; set; }
        public string ConManager { get; set; }
        public string ConClientName { get; set; }
        public string ConDoclocation { get; set; }
        public string ConNotes { get; set; }
        public string ConType { get; set; }
        public string ConObservations { get; set; }
        public int? ConExported { get; set; }
        public string ConWorkgrp { get; set; }
        public string ContactId { get; set; }
        public string ConScopeofworks { get; set; }
        public string ConProjectManager { get; set; }
        public string ConContactName { get; set; }
        public string ExtraCustRef { get; set; }
        public DateTime? ContractCompletedDate { get; set; }
        public string AccountsCleared { get; set; }
        public string StatusChangeHistory { get; set; }
        public string CompletionDocs { get; set; }
        public string BillingType { get; set; }
        public string Postcode { get; set; }
        public DateTime? CriticalStartDate { get; set; }
        public DateTime? CriticalEndDate { get; set; }
        public DateTime? ConvertQuoteDate { get; set; }
        public string FormOfContract { get; set; }
        public short? PaymentTerms { get; set; }
        public short? InvAppPreference { get; set; }
        public string AccountsEmail { get; set; }
        public string InvoiceAddress { get; set; }
        public bool? IsCompletionDocumentsRequired { get; set; }
        public string AsBuiltDrawings { get; set; }
        public string OpticalFibre { get; set; }
        public string Omsmanual { get; set; }
        public int? AccountContactId { get; set; }
        public byte[] TimeStamp { get; set; }
        public string ReasonToReOpen { get; set; }
        public string OtherCompletionDoc { get; set; }
        public string ProjectSynopsis { get; set; }
        public int? DurationType { get; set; }
        public int? ContractDuration { get; set; }

        public virtual ICollection<OperationDetail> OperationDetails { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<PlantRequestDetail> PlantRequestDetails { get; set; }
        public virtual ICollection<PriceEnquiry> PriceEnquiries { get; set; }
        public virtual ICollection<ProjectCheckIndicator> ProjectCheckIndicators { get; set; }
        public virtual ICollection<ProjectLabourRequirement> ProjectLabourRequirements { get; set; }
        public virtual ICollection<ProjectSheq> ProjectSheqs { get; set; }
        public virtual ICollection<ValuationDetail> ValuationDetails { get; set; }
    }
}
