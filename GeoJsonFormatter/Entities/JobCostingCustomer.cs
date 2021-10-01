using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class JobCostingCustomer
    {
        public int Id { get; set; }
        public int? CustomerId { get; set; }
        public string CustomerRef { get; set; }
        public string Name { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string Address4 { get; set; }
        public string Address5 { get; set; }
        public string Contact { get; set; }
        public string Telephone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string LastUser { get; set; }
        public DateTime? DateTimeStamp { get; set; }
        public DateTime? LastUpdateTime { get; set; }
    }
}
