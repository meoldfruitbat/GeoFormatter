using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class PlantTransferControl
    {
        public long Id { get; set; }
        public long PlantId { get; set; }
        public string PlantGroup { get; set; }
        public string PlantType { get; set; }
        public string PlantRef { get; set; }
        public DateTime? TransferRequestDate { get; set; }
        public string TransferFromId { get; set; }
        public string TransferFromName { get; set; }
        public string TransferToId { get; set; }
        public string TransferToName { get; set; }
        public DateTime? TransferAcceptedDate { get; set; }
        public DateTime? TransferCancelledDate { get; set; }
        public string WhereaboutsId { get; set; }
        public string TransferCommentsIn { get; set; }
        public string Pic1FilenameIn { get; set; }
        public string Pic2FilenameIn { get; set; }
        public string Pic3FilenameIn { get; set; }
        public string Pic4FilenameIn { get; set; }
        public string TransferCommentsOut { get; set; }
        public string Pic1FilenameOut { get; set; }
        public string Pic2FilenameOut { get; set; }
        public string Pic3FilenameOut { get; set; }
        public string Pic4FilenameOut { get; set; }
        public string AcceptanceCheck { get; set; }
        public string TransferOutById { get; set; }
        public string TransferOutByName { get; set; }
        public string TransferOutSigFilename { get; set; }
        public string ScdreceiptIninitials { get; set; }
    }
}
