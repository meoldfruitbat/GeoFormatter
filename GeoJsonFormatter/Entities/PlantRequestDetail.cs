using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class PlantRequestDetail
    {
        public PlantRequestDetail()
        {
            PlantRequisitionDetails = new HashSet<PlantRequisitionDetail>();
        }

        public int Id { get; set; }
        public long? MainContractId { get; set; }
        public DateTime? CreatedOn { get; set; }

        public virtual ContractFile MainContract { get; set; }
        public virtual ICollection<PlantRequisitionDetail> PlantRequisitionDetails { get; set; }
    }
}
