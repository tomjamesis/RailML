using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class TtrackRefInGroup
    {
        public TtrackRefInGroup()
        {
            Eline = new HashSet<Eline>();
            ElocallyControlledArea = new HashSet<ElocallyControlledArea>();
            EocpPropEquipment = new HashSet<EocpPropEquipment>();
        }

        public short TtrackRefInGroupId { get; set; }

        public virtual ICollection<Eline> Eline { get; set; }
        public virtual ICollection<ElocallyControlledArea> ElocallyControlledArea { get; set; }
        public virtual ICollection<EocpPropEquipment> EocpPropEquipment { get; set; }
    }
}
