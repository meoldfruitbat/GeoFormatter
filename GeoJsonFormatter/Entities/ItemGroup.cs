using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class ItemGroup
    {
        public ItemGroup()
        {
            ItemThresholds = new HashSet<ItemThreshold>();
            ItemTypes = new HashSet<ItemType>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ItemThreshold> ItemThresholds { get; set; }
        public virtual ICollection<ItemType> ItemTypes { get; set; }
    }
}
