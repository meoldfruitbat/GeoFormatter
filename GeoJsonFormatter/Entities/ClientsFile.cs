using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class ClientsFile
    {
        public ClientsFile()
        {
            ClientProjectTeams = new HashSet<ClientProjectTeam>();
            EnquiryOtherContacts = new HashSet<EnquiryOtherContact>();
            QuoteAssociatedClients = new HashSet<QuoteAssociatedClient>();
            Vacancies = new HashSet<Vacancy>();
        }

        public long ClientId { get; set; }
        public string ClientTitle { get; set; }
        public string ClientFname { get; set; }
        public string ClientSname { get; set; }
        public string ClientDept { get; set; }
        public string ClientTel { get; set; }
        public string ClientMob { get; set; }
        public string ClientFax { get; set; }
        public string ClientEmail { get; set; }
        public string ClientActmgr { get; set; }
        public string ClientNotes { get; set; }
        public string ClientAddress01 { get; set; }
        public string ClientAddress02 { get; set; }
        public string ClientAddress03 { get; set; }
        public string ClientPostcode { get; set; }
        public string ClientCountry { get; set; }
        public string ClientWebPage { get; set; }
        public string ClientJobTitle { get; set; }
        public string ClientSuffix { get; set; }
        public string ClientCompanyName { get; set; }
        public string ClientHomePhone { get; set; }
        public string ClientCategories { get; set; }
        public string ClientEmailDisplayName { get; set; }
        public string ClientEmail2 { get; set; }
        public string ClientEmail2DisplayName { get; set; }
        public string ClientInvoiceAddress01 { get; set; }
        public string ClientInvoiceAddress02 { get; set; }
        public string ClientInvoiceAddress03 { get; set; }
        public string ClientInvoicePostcode { get; set; }
        public string ClientInvoiceHeader { get; set; }
        public string DisableAccount { get; set; }
        public string PartnerName { get; set; }
        public string ChildrensName { get; set; }
        public string Intrests { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public long? CompanyId { get; set; }

        public virtual ClientCompanyFile Company { get; set; }
        public virtual ICollection<ClientProjectTeam> ClientProjectTeams { get; set; }
        public virtual ICollection<EnquiryOtherContact> EnquiryOtherContacts { get; set; }
        public virtual ICollection<QuoteAssociatedClient> QuoteAssociatedClients { get; set; }
        public virtual ICollection<Vacancy> Vacancies { get; set; }
    }
}
