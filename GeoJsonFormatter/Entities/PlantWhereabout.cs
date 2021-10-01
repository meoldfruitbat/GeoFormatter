using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class PlantWhereabout
    {
        public long Id { get; set; }
        public string PlantId { get; set; }
        public string PlantGroup { get; set; }
        public string PlantType { get; set; }
        public string PlantRef { get; set; }
        public DateTime? IssuedDate { get; set; }
        public string IssuedToId { get; set; }
        public string IssuedToName { get; set; }
        public string IssuedById { get; set; }
        public string IssuedByName { get; set; }
        public DateTime? ReturnedDate { get; set; }
        public string ReturnedById { get; set; }
        public string ReturnedByName { get; set; }
        public string ReturnedToId { get; set; }
        public string ReturnedToName { get; set; }
        public string CurrentView { get; set; }
        public string ReturnListCheck { get; set; }
        public int? AssetNo { get; set; }
        public string GangTransfer { get; set; }
    }
}
