using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class PlantFile
    {
        public long PlantId { get; set; }
        public string ContractReference { get; set; }
        public string QuoteId { get; set; }
        public string ConPrefix { get; set; }
        public string ContractId { get; set; }
        public string PlantType { get; set; }
        public string PlantRef { get; set; }
        public string PlantMake { get; set; }
        public string PlantModel { get; set; }
        public string PlantSize { get; set; }
        public string PlantWeight { get; set; }
        public string PlantSerial { get; set; }
        public string PlantEngine { get; set; }
        public string PlantTyreSize { get; set; }
        public string PlantSupplier { get; set; }
        public string PlantDepot { get; set; }
        public string PlantSupAdd01 { get; set; }
        public string PlantSupAdd02 { get; set; }
        public string PlantSupAdd03 { get; set; }
        public string PlantSupAdd04 { get; set; }
        public string PlantSupDepot { get; set; }
        public string PlantSupTel { get; set; }
        public string PlantSupFax { get; set; }
        public string PlantSupEmail { get; set; }
        public DateTime? PlantQty { get; set; }
        public string PlantCost { get; set; }
        public DateTime? PlantDate { get; set; }
        public string PlantGang { get; set; }
        public string PlantIdfromPlantLookup { get; set; }
        public int? AssetNumber { get; set; }
        public string Extra1 { get; set; }
    }
}
