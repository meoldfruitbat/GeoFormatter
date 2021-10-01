using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class ItemStockTransferHistory
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public long TransferFrom { get; set; }
        public long TransferTo { get; set; }
        public decimal NoOfUnits { get; set; }
        public decimal ValueOfTransfer { get; set; }
        public int MethodOfTransfer { get; set; }
        public decimal TransferCost { get; set; }
        public DateTime TrasnsferedDate { get; set; }
        public long TransferBy { get; set; }

        public virtual Item Item { get; set; }
        public virtual ReferenceDatum MethodOfTransferNavigation { get; set; }
        public virtual OperativeFile TransferByNavigation { get; set; }
        public virtual ClientCompanyFile TransferFromNavigation { get; set; }
        public virtual ClientCompanyFile TransferToNavigation { get; set; }
    }
}
