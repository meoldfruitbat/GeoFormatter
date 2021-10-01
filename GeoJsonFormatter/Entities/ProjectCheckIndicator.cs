using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class ProjectCheckIndicator
    {
        public int Id { get; set; }
        public long? MainContractId { get; set; }
        public bool UtilityPrintComplete { get; set; }
        public bool UploadJobPackComplete { get; set; }
        public bool ReviewJobPackComplete { get; set; }
        public bool? ValidationCheckComplete { get; set; }
        public bool? ContractDocumentsComplete { get; set; }
        public bool? UploadRamsonTablets { get; set; }
        public bool? UploadOtherDocuments { get; set; }

        public virtual ContractFile MainContract { get; set; }
    }
}
