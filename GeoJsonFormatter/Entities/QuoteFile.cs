using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class QuoteFile
    {
        public QuoteFile()
        {
            AuditLogForWorksRates = new HashSet<AuditLogForWorksRate>();
            QuoteAssociatedClients = new HashSet<QuoteAssociatedClient>();
        }

        public long QuoteId { get; set; }
        public string QuoteYear { get; set; }
        public string QuotePrefix { get; set; }
        public string QuoteRev { get; set; }
        public string QuoteAssociate { get; set; }
        public DateTime? QuoteCreated { get; set; }
        public DateTime? QuoteDate { get; set; }
        public string QuotedBy { get; set; }
        public string QuoteLocation01 { get; set; }
        public string QuoteLocation02 { get; set; }
        public string QuoteLocation03 { get; set; }
        public string QuoteLocation04 { get; set; }
        public string QuoteClientId { get; set; }
        public string QuoteContactId { get; set; }
        public string QuoteClientName { get; set; }
        public string QuoteStatus { get; set; }
        public string QuoteConvertedby { get; set; }
        public int? QuoteCallback { get; set; }
        public DateTime? QuoteCallbackDate { get; set; }
        public string QuoteNotes { get; set; }
        public decimal? QuoteNetValue { get; set; }
        public decimal? QuoteConValue { get; set; }
        public decimal? QuoteValue { get; set; }
        public string QuoteConverted { get; set; }
        public string QuoteWorkgrp { get; set; }
        public string QuoteFolder { get; set; }
        public string QuoteContype { get; set; }
        public string QuoteScopeofworks { get; set; }
        public string QuoteWhichInvoiceAddress { get; set; }
        public DateTime? QuoteSubmittedDate { get; set; }
        public string EnquiryEstimatedValue { get; set; }
        public DateTime? ProjectedStartDate { get; set; }
        public string PercentagePossibility { get; set; }
        public string Committed { get; set; }
        public string TermContractId { get; set; }
        public DateTime? LostDate { get; set; }
        public string LeadSource { get; set; }
        public string Rating { get; set; }
        public string Region { get; set; }
        public string ClientSector { get; set; }
        public string WorkStreamSector { get; set; }
        public bool? IsUtilityPrintsRequired { get; set; }
        public bool? IsSurveyRequired { get; set; }
        public string EnquiryStatus { get; set; }
        public long? LeadId { get; set; }
        public DateTime? EstStartDate { get; set; }
        public string QuoteContactName { get; set; }
        public string QuoteName { get; set; }
        public string ReasonToClose { get; set; }
        public string ReasonToCloseOther { get; set; }
        public DateTime? QuoteExpiryDate { get; set; }
        public byte[] TimeStamp { get; set; }
        public string ReasonToReOpen { get; set; }
        public string ReasonToLostDeclined { get; set; }
        public DateTime? OrderExpectedDate { get; set; }

        public virtual ICollection<AuditLogForWorksRate> AuditLogForWorksRates { get; set; }
        public virtual ICollection<QuoteAssociatedClient> QuoteAssociatedClients { get; set; }
    }
}
