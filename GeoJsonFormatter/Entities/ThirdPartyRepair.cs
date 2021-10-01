using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class ThirdPartyRepair
    {
        public Guid Id { get; set; }
        public Guid? CompanyId { get; set; }
        public long? NumericCompanyId { get; set; }
        public DateTime DateBooked { get; set; }
        public DateTime DateBookedInForRepair { get; set; }
        public string InitialComments { get; set; }
        public long PlantId { get; set; }
        public long TicketNo { get; set; }
        public short ItemNo { get; set; }
        public double CostOfRepair { get; set; }
        public string PurchaseOrderNo { get; set; }
        public DateTime? DateReceived { get; set; }
        public DateTime? DateClosed { get; set; }
        public string ClosingComments { get; set; }
    }
}
